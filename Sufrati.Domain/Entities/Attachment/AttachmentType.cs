using Sufrati.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sufrati.Domain.Entities
{
    public class AttachmentType : BaseEntity
    {
        

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string AttachmentDescAr { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string AttachmentDescEn { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal MaxSize { get; set; }

        public List<AttachmentTypeFileType> FileTypes { get; set; }
    }
}
