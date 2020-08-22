using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sufrati.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Data.Configurations
{
    public class UserGroupConfiguration
    {
        public UserGroupConfiguration(EntityTypeBuilder<UserGroup> entity)
        {
            entity.HasIndex(e => new { e.ID, e.GroupID, e.UserID }).IsUnique();
            entity.HasOne(e => e.User);
            entity.HasOne(e => e.Group);

            entity.HasData(
              new UserGroup()
              {
                  ID = 152000000000001,
                  GroupID = 147000000000001,
                  UserID = 101000000000001
              }
              );
        }
    }
}
