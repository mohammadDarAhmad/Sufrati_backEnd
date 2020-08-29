using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Sufrati.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        [Required]
        public long ID { get; set; }

        public long? CreatedByID { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public long? LastModifiedByID { get; set; }

        [Required]
        public DateTime LastModifiedDate { get; set; }

        [Required]
        public string IPAddress { get; set; }


    }
}
