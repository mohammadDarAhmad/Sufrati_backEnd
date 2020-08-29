using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sufrati.Domain.Entities;
using System;

namespace Sufrati.Data.Configurations
{
    public class AttachmentTypeFileTypeConfiguration
    {
        public AttachmentTypeFileTypeConfiguration(EntityTypeBuilder<AttachmentTypeFileType> entity)
        {
            entity.HasOne(e => e.AttachmentType).WithMany(e => e.FileTypes).HasForeignKey(e => e.AttachmentTypeID).HasConstraintName("FK_AttachmentType_AttachmentTypeFileType_AttachmentTypeID").OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(e => e.FileType).WithMany().HasForeignKey(e => e.FileTypeID).HasConstraintName("FK_FileType_AttachmentTypeFileType_FileTypeID").OnDelete(DeleteBehavior.NoAction);
            entity.HasData(
                new AttachmentTypeFileType
                {
                    ID = 110100000000001,
                    AttachmentTypeID = 199000000000001,
                    FileTypeID = 198000000000001,
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
