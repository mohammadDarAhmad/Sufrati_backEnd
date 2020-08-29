using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Sufrati.Domain.Entities
{
    public class SystemConstant : BaseEntity
    {
        [Required]
        public int NotifyBanksForInvoiceAfter { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 4)")]
        public decimal MaxCompensationAmount { get; set; }

        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal TotalQuantitativeCriteriaMaxScore { get; set; }

        [Required]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal QualitativeCriteriaMaxScore { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 4)")]
        public double FinesAmountPerEachDayDelayed { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string OutgoingSMTPServer { get; set; }

        public bool SMTPServerRequiresAuthentication { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Username { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Password { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string FormEmailAddress { get; set; }

        public bool EnableSSL { get; set; }

        public int SMTPPortNumber { get; set; }
        [Required]
        [Column(TypeName = "char(7)")]
        public string Weekend { get; set; }

 

        [Required]
        public string AttachmentPath { get; set; }



    }
}
