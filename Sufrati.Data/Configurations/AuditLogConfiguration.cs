using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sufrati.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Data.Configurations
{
    class AuditLogConfiguration
    {
        public AuditLogConfiguration(EntityTypeBuilder<AuditLog> entity)
        {
            entity.Property(e => e.ID);
            entity.Property(e => e.UpdatedByID);
            entity.Property(e => e.TableName);
            entity.Property(e => e.ColumnName);
            entity.Property(e => e.OldValue);
            entity.Property(e => e.NewValue);
            entity.Property(e => e.UpdatedDate);
            entity.Property(e => e.IPAddress);
            entity.Property(e => e.InstanceIdValue);


        }
    }
}