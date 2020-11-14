using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Sufrati.Domain.Entities
{

    public class Recipe : BaseEntity
    {

        [Required]
        [MaxLength(100)]
        public string UserID { get; set; }

        [Required]
        public string TitleRecipeAr { get; set; }

        [Required]
        public string TitleRecipeEn { get; set; }


        public long PreparationTimeMinutes { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string Ingredients { get; set; }

        //[ForeignKey("GeneralLookupValueID")]
        //[Required]
        //public long UserTypeID { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string PreparationMethod { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string photo { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Video { get; set; }
        public string ClassificationClassification { get; set; }

        public string classificationInternational { get; set; }

    }
}

