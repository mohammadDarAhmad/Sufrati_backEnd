using System.ComponentModel.DataAnnotations;

namespace Sufrati.Domain.ApiModels
{
    public class GeneralLookupValueForView
    {
        [Required]
        public long ID { get; set; }
        [Required]
        public long GeneralLookupTypeID { get; set; }
        [Required]
        public string ValueAr { get; set; }
        public string ValueEn { get; set; }
        public GeneralLookupTypeInnerVM GeneralLookupType { get; set; }


    }
}