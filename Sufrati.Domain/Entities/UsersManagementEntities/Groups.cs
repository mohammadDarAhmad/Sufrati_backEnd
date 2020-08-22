using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sufrati.Domain.Entities
{
    public class Groups : BaseEntity
    {

        [Required]
        public string NameAr { get; set; }

        [Required]
        [Column(TypeName ="nvarchar(200)")]
        public string NameEn { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }

        public virtual List<UserGroup> UserGroups { get; set; }

    }
}
