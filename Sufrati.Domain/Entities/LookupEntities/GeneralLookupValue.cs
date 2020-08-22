using Sufrati.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sufrati.Domain.Entities
{
    public class GeneralLookupValue : BaseEntity
    {

        [Required]
        [ForeignKey("GeneralLookupTypeID")]
        public long GeneralLookupTypeID { get; set; }

        [Required]
        public string ValueAr { get; set; }

        public string ValueEn { get; set; }


        public virtual GeneralLookupType GeneralLookupType { get; set; }


    }
}
