using Sufrati.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sufrati.Domain.Entities
{
    public class FileType : BaseEntity
    {


        [Required]
        [Column(TypeName = "varchar(5)")]
        public string FileExtension { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string FileTypeDescAr { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string FileTypeDescEn { get; set; }
    }
}
