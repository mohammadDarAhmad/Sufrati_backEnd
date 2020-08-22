using System.ComponentModel.DataAnnotations;

namespace Sufrati.Domain.ApiModels
{
    public class GeneralLookupTypeVM
    {
        public long ID { get; set; }
        [Required]
        public string GeneralLookupNamear { get; set; }
        [Required]
        public string GeneralLookupNameen { get; set; }
    }
}