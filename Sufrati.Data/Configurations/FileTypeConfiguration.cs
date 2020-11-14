using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Sufrati.Domain.Entities;

namespace Sufrati.Data.Configurations
{
    public class FileTypeConfiguration
    {
        public FileTypeConfiguration(EntityTypeBuilder<FileType> entity)
        {
            entity.HasIndex(e => e.FileExtension).IsUnique().HasName("UX_FileType");
            entity.HasData
                (
                 new FileType
                 {
                     ID = 198000000000001,
                     FileExtension = ".jpeg",
                     CreatedByID = 101000000000001,
                     CreatedDate = DateTime.Now,
                     LastModifiedByID = 101000000000001,
                     LastModifiedDate = DateTime.Now,
                     IPAddress = "127.0.0.1"
                 },
                 new FileType
                 {
                     ID = 198000000000002,
                     FileExtension = ".pdf",
                     CreatedByID = 101000000000001,
                     CreatedDate = DateTime.Now,
                     LastModifiedByID = 101000000000001,
                     LastModifiedDate = DateTime.Now,
                     IPAddress = "127.0.0.1"
                 },
                 new FileType
                 {
                     ID = 198000000000003,
                     FileExtension = ".rar",
                     CreatedByID = 101000000000001,
                     CreatedDate = DateTime.Now,
                     LastModifiedByID = 101000000000001,
                     LastModifiedDate = DateTime.Now,
                     IPAddress = "127.0.0.1"
                 },
                 new FileType
                 {
                     ID = 198000000000004,
                     FileExtension = ".xls",
                     CreatedByID = 101000000000001,
                     CreatedDate = DateTime.Now,
                     LastModifiedByID = 101000000000001,
                     LastModifiedDate = DateTime.Now,
                     IPAddress = "127.0.0.1"
                 },
                 new FileType
                 {
                     ID = 198000000000005,
                     FileExtension = ".xlsx",
                     CreatedByID = 101000000000001,
                     CreatedDate = DateTime.Now,
                     LastModifiedByID = 101000000000001,
                     LastModifiedDate = DateTime.Now,
                     IPAddress = "127.0.0.1"
                 },
                 new FileType
                 {
                     ID = 198000000000006,
                     FileExtension = ".docx",
                     CreatedByID = 101000000000001,
                     CreatedDate = DateTime.Now,
                     LastModifiedByID = 101000000000001,
                     LastModifiedDate = DateTime.Now,
                     IPAddress = "127.0.0.1"
                 },
                 new FileType
                 {
                     ID = 198000000000007,
                     FileExtension = ".doc",
                     CreatedByID = 101000000000001,
                     CreatedDate = DateTime.Now,
                     LastModifiedByID = 101000000000001,
                     LastModifiedDate = DateTime.Now,
                     IPAddress = "127.0.0.1"
                 },
                 new FileType
                 {
                     ID = 198000000000008,
                     FileExtension = ".png",
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
