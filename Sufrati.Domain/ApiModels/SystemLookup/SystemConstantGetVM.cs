using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain.ApiModels
{
   public class SystemConstantGetVM
    {
        public long ID { get; set; }
        public int NotifyBanksForInvoiceAfter { get; set; }
        public decimal MaxCompensationAmount { get; set; }
        public decimal QualitativeCriteriaMaxScore { get; set; }
        public decimal TotalQuantitativeCriteriaMaxScore { get; set; }
        public string OutgoingSMTPServer { get; set; }

        public bool SMTPServerRequiresAuthentication { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string FormEmailAddress { get; set; }

        public bool EnableSSL { get; set; }

        public int SMTPPortNumber { get; set; }
        public double FinesAmountPerEachDayDelayed { get; set; }
       // public List<WeekendInnerVM> WeekendDays { get; set; }
        public long BaseCurrencyID { get; set; }
        public string AttachmentPath { get; set; }
      
    }
}
