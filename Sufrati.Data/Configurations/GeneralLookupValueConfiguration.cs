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
                      CreatedDate = DateTime.Now,
                      LastModifiedByID = 101000000000001,
                      LastModifiedDate = DateTime.Now,
                      IPAddress = "127.0.0.1"
                  },
                  new GeneralLookupValue()
                  {
                      ID = 107000000000002,
                      GeneralLookupTypeID = 105000000000002,
                      ValueAr = "رئيسي",
                      ValueEn = "Main",
                      CreatedByID = 101000000000001,
                      CreatedDate = DateTime.Now,
                      LastModifiedByID = 101000000000001,
                      LastModifiedDate = DateTime.Now,
                      IPAddress = "127.0.0.1"
                  },
                   new GeneralLookupValue()
                   {
                       ID = 107000000000003,
                       GeneralLookupTypeID = 105000000000002,
                       ValueAr = "سلطة",
                       ValueEn = "Salad",
                       CreatedByID = 101000000000001,
                       CreatedDate = DateTime.Now,
                       LastModifiedByID = 101000000000001,
                       LastModifiedDate = DateTime.Now,
                       IPAddress = "127.0.0.1"
                   }, new GeneralLookupValue()
                   {
                       ID = 107000000000004,
                       GeneralLookupTypeID = 105000000000002,
                       ValueAr = "حلوى",
                       ValueEn = "Sweet",
                       CreatedByID = 101000000000001,
                       CreatedDate = DateTime.Now,
                       LastModifiedByID = 101000000000001,
                       LastModifiedDate = DateTime.Now,
                       IPAddress = "127.0.0.1"
                   }, new GeneralLookupValue()
                   {
                       ID = 107000000000005,
                       GeneralLookupTypeID = 105000000000002,
                       ValueAr = "مشروب",
                       ValueEn = "Drink",
                       CreatedByID = 101000000000001,
                       CreatedDate = DateTime.Now,
                       LastModifiedByID = 101000000000001,
                       LastModifiedDate = DateTime.Now,
                       IPAddress = "127.0.0.1"
                   }, new GeneralLookupValue()
                   {
                       ID = 107000000000006,
                       GeneralLookupTypeID = 105000000000002,
                       ValueAr = "خفيف",
                       ValueEn = "Light",
                       CreatedByID = 101000000000001,
                       CreatedDate = DateTime.Now,
                       LastModifiedByID = 101000000000001,
                       LastModifiedDate = DateTime.Now,
                       IPAddress = "127.0.0.1"
                   }, new GeneralLookupValue()
                   {
                       ID = 107000000000007,
                       GeneralLookupTypeID = 105000000000002,
                       ValueAr = "ساندويش",
                       ValueEn = "Sandwich",
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
