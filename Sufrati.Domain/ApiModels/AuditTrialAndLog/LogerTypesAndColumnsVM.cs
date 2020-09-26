using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain.ApiModels
{
    public class LogerTypesAndColumnsVM
    {
        public long ID { get; set; }     
        public List<LoogerColumnsVM> Columns { get; set; }
    }
}
