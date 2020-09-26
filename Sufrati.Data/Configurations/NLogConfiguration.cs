using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sufrati.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Data.Configurations
{
    public class NLogConfiguration
    {
        public NLogConfiguration(EntityTypeBuilder<MyNLog> entity)
        {
            //entity.HasOne(e => e.Entity).WithMany().HasForeignKey(e => e.EntityID).OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);
            entity.HasOne(e => e.User).WithMany().HasForeignKey(e => e.UserID).OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);
            entity.HasOne(e => e.PasswordChangedByUser).WithMany().HasForeignKey(e => e.PasswordChangedByID).OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

        }
    }

}
