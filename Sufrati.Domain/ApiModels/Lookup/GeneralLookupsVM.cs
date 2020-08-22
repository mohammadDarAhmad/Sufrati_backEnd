using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain.ApiModels
{
    public class GeneralLookupsVM
    {
        public List<GeneralLookupValueForView> GeneralLookupValuesVM { get; set; }
        public List<GeneralLookupTypeVM> GeneralLookupTypesVM { get; set; }

    }
}
