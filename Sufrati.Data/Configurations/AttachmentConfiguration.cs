using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sufrati.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Data.Configurations
{
    public class AttachmentConfiguration
    {
        public AttachmentConfiguration(EntityTypeBuilder<Attachment> entity)
        {
            entity.HasData(
                new Attachment()
                {
                    ID = 160000000000001,
                    OriginalFileName = "File1",
                    PhysicalFileName = "Filefile",
                    FilePath = "00",

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