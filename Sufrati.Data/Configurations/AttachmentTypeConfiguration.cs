using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sufrati.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Data.Configurations
{
    public class AttachmentTypeConfiguration
    {   
        public AttachmentTypeConfiguration(EntityTypeBuilder<AttachmentType> entity)
        {
            entity.HasData(
                new AttachmentType
                {
                    ID = 199000000000001,
                    AttachmentDescAr = "عربي",
                    AttachmentDescEn = "eng",
                    MaxSize = 10,
                    CreatedByID = 101000000000001,
                    CreatedDate = DateTime.Now,
                    LastModifiedByID = 101000000000001,
                    LastModifiedDate = DateTime.Now,
                    IPAddress = "127.0.0.1"
                },
                new AttachmentType
                {
                    ID = 199000000000002,
                    AttachmentDescAr = "عربي",
                    AttachmentDescEn = "eng",
                    MaxSize = 10,
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