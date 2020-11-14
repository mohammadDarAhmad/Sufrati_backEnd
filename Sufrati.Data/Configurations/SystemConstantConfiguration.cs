using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Sufrati.Domain.Entities;

namespace Sufrati.Data.Configurations
{
    public class SystemConstantConfiguration
    {
        public SystemConstantConfiguration(EntityTypeBuilder<SystemConstant> entity)
        {

            entity.HasData(
                new SystemConstant()
                {
                    ID = 107000000000001,
                    NotifyBanksForInvoiceAfter = 90,
                    MaxCompensationAmount = 20000,
                    FinesAmountPerEachDayDelayed = 0.0001,//0.001
                    TotalQuantitativeCriteriaMaxScore = 70,
                    Weekend = "0000110",
                    AttachmentPath = "C:\\SufratiAttachment",
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
