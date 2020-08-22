using Sufrati.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sufrati.Domain.Entities
{
    public class ChangePasswordHistory
    {
        [Required]
        [Key]
        public long ID { get; set; }

        [Required]
        public long ResourceID { get; set; }

        [Required]
        public DateTime ChangeDate { get; set; }

        [Required]
        public long UserID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string NewPassword { get; set; } 
        
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string OldPassword { get; set; }

        [Required]
        public long ByUserID { get; set; }


        public User User { get; set; }
    }
}
