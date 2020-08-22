using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sufrati.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Data.Configurations
{
    public class GeneralLookupValueConfiguration
    {
        public GeneralLookupValueConfiguration(EntityTypeBuilder<GeneralLookupValue> entity)
        {

            entity.HasOne(e => e.GeneralLookupType).WithMany(e => e.GeneralLookupValues).HasForeignKey(e => e.GeneralLookupTypeID);

            entity.Property(e => e.ValueAr).IsRequired();
            entity.HasData(
                     new GeneralLookupValue()
                     {
                         ID = 106000000000001,
                         GeneralLookupTypeID = 105000000000001,
                         ValueAr = "آدمن رئيسي",
                         ValueEn = "admin",
                         CreatedByID = 101000000000001,
                         Created_Date = DateTime.Now,
                         LastModifiedByID = 101000000000001,
                         LastModifiedDate = DateTime.Now,
                         IPAddress = "127.0.0.1"
                     }
                    );
        }
    }
}
