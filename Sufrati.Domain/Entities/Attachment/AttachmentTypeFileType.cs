using Sufrati.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sufrati.Domain.Entities
{
    public class AttachmentTypeFileType : BaseEntity
    {
        [Required]
        public long AttachmentTypeID { get; set; }

        [Required]
        public long FileTypeID { get; set; }

        public AttachmentType AttachmentType { get; set; }
        public FileType FileType { get; set; }
    }
}
