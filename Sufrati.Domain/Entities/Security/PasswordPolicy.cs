using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sufrati.Domain.Entities
{
    public class PasswordPolicy : BaseEntity
    {
        [Required]
        public bool FirstLoginChangePassword { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(1000)")]
        public string TitleAr { get; set; }

        [Required]
        [Column(TypeName = "varchar(1000)")]
        public string TitleEn { get; set; }

        [Required]
        public int MinLength { get; set; }

        [Required]
        public int SessionAfterEnd { get; set; }

        [Required]
        public int SuspendPasswordAfter { get; set; }

        [Required]
        public bool IncludeSpecialCharacter { get; set; }

        [Required]
        public bool IncludeNumeric { get; set; }

        [Required]
        public bool IncludeCharacter { get; set; }

        public virtual List<User> Users { get; set; }
    }
}
