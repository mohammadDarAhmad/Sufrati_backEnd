using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sufrati.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Sufrati.Data.Configurations
{
    public class GeneralLookupTypeConfiguration
    {
        public GeneralLookupTypeConfiguration(EntityTypeBuilder<GeneralLookupType> entity)
        {

            entity.HasData(
              new GeneralLookupType() { ID = 105000000000001, GeneralLookupNameEn = "User Type", GeneralLookupNameAr = "نوع المستخدم" }
       );

        }
    }
}