using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sufrati.Domain.Entities
{
    public class UserGroup
    {
        [Required]
        [Key]
        public long ID { get; set; }

        [Required]
        [ForeignKey("UserID")]
        public long UserID { get; set; }

        [Required]
        [ForeignKey("GroupID")]
        public long GroupID { get; set; }

        public virtual Groups Group { get; set; }
        public virtual User User { get; set; }

    }
}
