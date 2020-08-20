﻿using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Sufrati.Domain.Entities;
using Sufrati.Data.Configurations;

namespace Sufrati.Data
{
    class SufratiContext : DbContext
    {
        private IHttpContextAccessor httpContextAccessor;

        //  public virtual DbSet<GeneralLookupType> GeneralLookupType { get; set; }
        public virtual DbSet<AuditLog> AuditLog { get; set; }

        public SufratiContext(DbContextOptions<SufratiContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
            this.httpContextAccessor = httpContextAccessor;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //new EntityCLassConfiguration(modelBuilder.Entity<EntityCLass>());
            new AuditLogConfiguration(modelBuilder.Entity<AuditLog>());

            //new GeneralLookupTypeConfiguration(modelBuilder.Entity<GeneralLookupType>());
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var modifiedEntities = this.ChangeTracker.Entries().Where(p => p.State == EntityState.Modified).ToList();
            var now = System.DateTime.Now;
            foreach (var change in modifiedEntities)
            {
                var entityName = change.Entity.GetType().Name;
                if (entityName.Contains("Proxy"))
                    entityName = entityName.Remove(entityName.IndexOf("Proxy"));
                var UserID = "";
                var IPAddress = this.httpContextAccessor?.HttpContext?.Connection?.RemoteIpAddress.ToString();
                if (IPAddress == "::1") { IPAddress = this.httpContextAccessor?.HttpContext?.Connection?.LocalIpAddress.ToString(); }

                var list = this.httpContextAccessor?.HttpContext?.User?.Claims?.ToList();
                if (list.Count == 0 && entityName == "RegisteredUser")
                    UserID = change.OriginalValues["ID"].ToString();
                else if (list.Count >= 5) { UserID = list[4]?.Value; }
                foreach (var property in change.OriginalValues.Properties)
                {
                    object originalValue = null, currentValue = null;
                    originalValue = change.OriginalValues[property];
                    currentValue = change.CurrentValues[property];
                    var InstanceIdValue = change.OriginalValues["ID"];
                    if (originalValue != null && currentValue != null)
                    {
                        if ((originalValue.ToString() != currentValue.ToString()) && (!string.IsNullOrEmpty(originalValue?.ToString()) || !string.IsNullOrEmpty(currentValue?.ToString())))
                        {
                            AuditLog log = new AuditLog()
                            {
                                UpdatedByID = UserID,
                                IPAddress = IPAddress,
                                TableName = entityName,
                                ColumnName = property.Name,
                                OldValue = originalValue.ToString(),
                                NewValue = currentValue.ToString(),
                                UpdatedDate = now,
                                InstanceIdValue = InstanceIdValue?.ToString()
                            };
                            AuditLog.Add(log);
                        }
                    }
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }


    }

}