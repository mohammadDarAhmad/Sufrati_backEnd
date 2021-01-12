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
                   }, new GeneralLookupValue()
                   {
                       ID = 107000000000008,
                       GeneralLookupTypeID = 105000000000003,
                       ValueAr = "فلسطيني",
                       ValueEn = "Palestaine",
                       CreatedByID = 101000000000001,
                       CreatedDate = DateTime.Now,
                       LastModifiedByID = 101000000000001,
                       LastModifiedDate = DateTime.Now,
                       IPAddress = "127.0.0.1"
                   }, new GeneralLookupValue()
                   {
                       ID = 107000000000009,
                       GeneralLookupTypeID = 105000000000003,
                       ValueAr = "الجزائر",
                       ValueEn = "Algeria",
                       CreatedByID = 101000000000001,
                       CreatedDate = DateTime.Now,
                       LastModifiedByID = 101000000000001,
                       LastModifiedDate = DateTime.Now,
                       IPAddress = "127.0.0.1"
                   }, new GeneralLookupValue()
                   {
                       ID = 107000000000010,
                       GeneralLookupTypeID = 105000000000003,
                       ValueAr = "سوريا",
                       ValueEn = "Syrian",
                       CreatedByID = 101000000000001,
                       CreatedDate = DateTime.Now,
                       LastModifiedByID = 101000000000001,
                       LastModifiedDate = DateTime.Now,
                       IPAddress = "127.0.0.1"
                   }, new GeneralLookupValue()
                   {
                       ID = 107000000000011,
                       GeneralLookupTypeID = 105000000000003,
                       ValueAr = "تونس",
                       ValueEn = "Tonsia",
                       CreatedByID = 101000000000001,
                       CreatedDate = DateTime.Now,
                       LastModifiedByID = 101000000000001,
                       LastModifiedDate = DateTime.Now,
                       IPAddress = "127.0.0.1"
                   }, new GeneralLookupValue()
                   {
                       ID = 107000000000012,
                       GeneralLookupTypeID = 105000000000003,
                       ValueAr = "اليمن",
                       ValueEn = "Yaman",
                       CreatedByID = 101000000000001,
                       CreatedDate = DateTime.Now,
                       LastModifiedByID = 101000000000001,
                       LastModifiedDate = DateTime.Now,
                       IPAddress = "127.0.0.1"
                   }, new GeneralLookupValue()
                   {
                       ID = 107000000000013,
                       GeneralLookupTypeID = 105000000000003,
                       ValueAr = "السعودية",
                       ValueEn = "Soudia",
                       CreatedByID = 101000000000001,
                       CreatedDate = DateTime.Now,
                       LastModifiedByID = 101000000000001,
                       LastModifiedDate = DateTime.Now,
                       IPAddress = "127.0.0.1"
                   }, new GeneralLookupValue()
                   {
                       ID = 107000000000014,
                       GeneralLookupTypeID = 105000000000003,
                       ValueAr = "لبنان",
                       ValueEn = "Lebaone",
                       CreatedByID = 101000000000001,
                       CreatedDate = DateTime.Now,
                       LastModifiedByID = 101000000000001,
                       LastModifiedDate = DateTime.Now,
                       IPAddress = "127.0.0.1"
                   }, new GeneralLookupValue()
                   {
                       ID = 107000000000015,
                       GeneralLookupTypeID = 105000000000003,
                       ValueAr = "الاردن",
                       ValueEn = "Jordan",
                       CreatedByID = 101000000000001,
                       CreatedDate = DateTime.Now,
                       LastModifiedByID = 101000000000001,
                       LastModifiedDate = DateTime.Now,
                       IPAddress = "127.0.0.1"
                   }, new GeneralLookupValue()
                   {
                       ID = 107000000000016,
                       GeneralLookupTypeID = 105000000000003,
                       ValueAr = "المغرب",
                       ValueEn = "Morracow",
                       CreatedByID = 101000000000001,
                       CreatedDate = DateTime.Now,
                       LastModifiedByID = 101000000000001,
                       LastModifiedDate = DateTime.Now,
                       IPAddress = "127.0.0.1"
                   }, new GeneralLookupValue()
                   {
                       ID = 107000000000018,
                       GeneralLookupTypeID = 105000000000003,
                       ValueAr = "مصر",
                       ValueEn = "Eygpt",
                       CreatedByID = 101000000000001,
                       CreatedDate = DateTime.Now,
                       LastModifiedByID = 101000000000001,
                       LastModifiedDate = DateTime.Now,
                       IPAddress = "127.0.0.1"
                   }
                   , new GeneralLookupValue()
                   {
                       ID = 107000000000019,
                       GeneralLookupTypeID = 105000000000004,
                       ValueAr = "لبنيات",
                       ValueEn = "Laben",
                       CreatedByID = 101000000000001,
                       CreatedDate = DateTime.Now,
                       LastModifiedByID = 101000000000001,
                       LastModifiedDate = DateTime.Now,
                       IPAddress = "127.0.0.1"
                   }
                    , new GeneralLookupValue()
                    {
                        ID = 107000000000020,
                        GeneralLookupTypeID = 105000000000004,
                        ValueAr = "ارزيات",
                        ValueEn = "Raise",
                        CreatedByID = 101000000000001,
                        CreatedDate = DateTime.Now,
                        LastModifiedByID = 101000000000001,
                        LastModifiedDate = DateTime.Now,
                        IPAddress = "127.0.0.1"
                    }
                     , new GeneralLookupValue()
                     {
                         ID = 107000000000021,
                         GeneralLookupTypeID = 105000000000004,
                         ValueAr = "يخنيات",
                         ValueEn = "yaken",
                         CreatedByID = 101000000000001,
                         CreatedDate = DateTime.Now,
                         LastModifiedByID = 101000000000001,
                         LastModifiedDate = DateTime.Now,
                         IPAddress = "127.0.0.1"
                     }
                      , new GeneralLookupValue()
                      {
                          ID = 107000000000022,
                          GeneralLookupTypeID = 105000000000004,
                          ValueAr = "قبب",
                          ValueEn = "kbb",
                          CreatedByID = 101000000000001,
                          CreatedDate = DateTime.Now,
                          LastModifiedByID = 101000000000001,
                          LastModifiedDate = DateTime.Now,
                          IPAddress = "127.0.0.1"
                      }, new GeneralLookupValue()
                      {
                          ID = 107000000000023,
                          GeneralLookupTypeID = 105000000000004,
                          ValueAr = "ورقيات",
                          ValueEn = "workss",
                          CreatedByID = 101000000000001,
                          CreatedDate = DateTime.Now,
                          LastModifiedByID = 101000000000001,
                          LastModifiedDate = DateTime.Now,
                          IPAddress = "127.0.0.1"
                      }, new GeneralLookupValue()
                      {
                          ID = 107000000000024,
                          GeneralLookupTypeID = 105000000000004,
                          ValueAr = "عدسيات",
                          ValueEn = "3ds",
                          CreatedByID = 101000000000001,
                          CreatedDate = DateTime.Now,
                          LastModifiedByID = 101000000000001,
                          LastModifiedDate = DateTime.Now,
                          IPAddress = "127.0.0.1"
                      },
                   new GeneralLookupValue()
                   {
                ID = 107000000000025,
                          GeneralLookupTypeID = 105000000000004,
                          ValueAr = "الصواني",
                          ValueEn = "ss",
                          CreatedByID = 101000000000001,
                          CreatedDate = DateTime.Now,
                          LastModifiedByID = 101000000000001,
                          LastModifiedDate = DateTime.Now,
                          IPAddress = "127.0.0.1"
                      },
                   new GeneralLookupValue()
                   {
                       ID = 107000000000026,
                       GeneralLookupTypeID = 105000000000002,
                       ValueAr = "مقبلات",
                       ValueEn = "AA",
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
