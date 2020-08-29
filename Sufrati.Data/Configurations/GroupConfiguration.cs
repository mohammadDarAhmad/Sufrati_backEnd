using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sufrati.Domain.Entities;

namespace Sufrati.Data.Configurations
{
    public class GroupConfiguration
    {
        public GroupConfiguration(EntityTypeBuilder<Groups> entity)
        {
            entity.HasIndex(e => e.ID).IsUnique();
            entity.HasIndex(e => e.NameEn).IsUnique();
            entity.HasIndex(e => e.NameAr).IsUnique();
            entity.HasMany(e => e.UserGroups);

            entity.HasData(
                new Groups()
                {
                    ID = 147000000000001,
                    NameAr = "أدمن",
                    NameEn = "Admins",
                    DescriptionAr = "هذه المجموعة للمسؤولين الرئيسين",
                    DescriptionEn = "this group for Admins",
                    CreatedByID = 101000000000001,
                    CreatedDate = DateTime.Now,
                    LastModifiedByID = 101000000000001,
                    LastModifiedDate = DateTime.Now,
                    IPAddress = "127.0.0.1"
                }
                );
        }
    }
}
