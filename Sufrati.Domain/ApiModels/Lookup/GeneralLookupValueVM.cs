using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sufrati.Domain.ApiModels
{
    public class GeneralLookupValueVM
    {
        [Required]
        public long ID { get; set; }
        [Required]
        public long GeneralLookupTypeID { get; set; }
        [Required]
        public string ValueAr { get; set; }
        public string ValueEn { get; set; }
    }
}
