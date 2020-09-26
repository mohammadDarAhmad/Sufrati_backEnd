using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sufrati.Domain.Entities
{
    public class SystemMessage
    {
        [Required]
        [Key]
        public long ID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(400)")]
        public string MessageDescAr { get; set; }

        [Required]
        public string MessageDescEn { get; set; }

        [Required]
        public long MessageTypeID { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string SystemMessageCode { get; set; }         

        public GeneralLookupValue MessageType { get; set; }
    }
}
