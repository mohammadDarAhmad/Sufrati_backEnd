using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain.ApiModels
{
    public class AttachmentTypeModel
    {
        public long ID { get; set; }
     
        public string AttachmentDescAr { get; set; }
        
        public string AttachmentDescEn { get; set; }
  
        public decimal MaxSize { get; set; }
    }
}
