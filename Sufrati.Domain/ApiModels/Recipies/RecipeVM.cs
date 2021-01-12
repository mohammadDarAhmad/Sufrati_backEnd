using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain.ApiModels
{
    public class RecipeVM
    {

        public string ID { get; set; }
        public string UserID { get; set; }


        public string TitleRecipeAr { get; set; }


        public string TitleRecipeEn { get; set; }


        public long PreparationTimeMinutes { get; set; }


        public string Ingredients { get; set; }

        //[ForeignKey("GeneralLookupValueID")]
        //[Required]
        //public long UserTypeID { get; set; }

        public string PreparationMethod { get; set; }

        public string photo { get; set; }

        public string Video { get; set; }
        public string ClassificationClassification { get; set; }

        public string classificationInternational { get; set; }
        public string ClassificationSufrati { get; set; }

    }
}


