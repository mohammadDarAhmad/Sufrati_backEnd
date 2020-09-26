using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain.ApiModels
{
    public class SystemMessageForAddVM
    {
        public long ID { get; set; }

        public string MessageDescAr { get; set; }

        public string MessageDescEn { get; set; }

        public long MessageTypeID { get; set; }
    }
}
