using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sufrati.Domain.Entities
{
    public class GeneralLookupType
    {
        [Key]
        [Required]
        public long ID { get; set; }

        [Required]
        public string GeneralLookupNameAr { get; set; }
        [Required]
        public string GeneralLookupNameEn { get; set; }


        public virtual List<GeneralLookupValue> GeneralLookupValues { get; set; }
       // public List<LookUpCodeMapping> LookUpCodes { get; set; }
    }
}
