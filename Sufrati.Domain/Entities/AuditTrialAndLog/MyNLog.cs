using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sufrati.Domain.Entities
{
    public class MyNLog
    {
        [Key]
        public long ID { get; set; }

        [Required]
        public DateTime LogDate { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string IPAddress { get; set; }

        public long? UserID { get; set; }

        public string RequestURL { get; set; }

        public string Action { get; set; }

        public long? EntityID { get; set; }

        [Required]
        public long LogTypeID { get; set; }

        public string ExceptionType { get; set; }

        public string ExceptionMessages { get; set; }

        public string MessagesCode { get; set; }

        public string AdditionalInfo { get; set; }

        public long? PasswordChangedByID { get; set; }

        public DateTime? LogoutTime { get; set; }

        public string Token { get; set; }

        public User User { get; set; }
        public User PasswordChangedByUser{ get; set; }
        public GeneralLookupValue LogType { get; set; }
    }
}
