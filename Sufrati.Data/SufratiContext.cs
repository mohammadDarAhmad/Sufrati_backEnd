using Microsoft.AspNetCore.Http;
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
    public class SufratiContext : DbContext
    {
        private IHttpContextAccessor httpContextAccessor;

        //  public virtual DbSet<GeneralLookupType> GeneralLookupType { get; set; }
        public virtual DbSet<AuditLog> AuditLog { get; set; }
        public virtual DbSet<GeneralLookupType> GeneralLookupType { get; set; }
        public virtual DbSet<GeneralLookupValue> GeneralLookupValue { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<PasswordPolicy> PasswordPolicy { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<UserGroup> UserGroup { get; set; }
        public virtual DbSet<SystemConstant> SystemConstant { get; set; }

        #region Attachment
        public DbSet<AttachmentType> AttachmentType { get; set; }
        public DbSet<Attachment> Attachment { get; set; }
        public DbSet<FileType> FileType { get; set; }
        public DbSet<AttachmentTypeFileType> AttachmentTypeFileType { get; set; }
        #endregion

        public SufratiContext(DbContextOptions<SufratiContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
            this.httpContextAccessor = httpContextAccessor;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //new EntityCLassConfiguration(modelBuilder.Entity<EntityCLass>());
            new PasswordPolicyConfiguration(modelBuilder.Entity<PasswordPolicy>());
            new UserConfiguration(modelBuilder.Entity<User>());
            new UserGroupConfiguration(modelBuilder.Entity<UserGroup>());
            new GeneralLookupTypeConfiguration(modelBuilder.Entity<GeneralLookupType>());
            new GeneralLookupValueConfiguration(modelBuilder.Entity<GeneralLookupValue>());
            new GroupConfiguration(modelBuilder.Entity<Groups>());
            new AuditLogConfiguration(modelBuilder.Entity<AuditLog>());
        }//new GeneralLookupTypeConfiguration(modelBuilder.Entity<GeneralLookupType>());

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
