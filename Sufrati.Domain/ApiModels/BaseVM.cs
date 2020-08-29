using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain.ApiModels
{
    public class BaseVM
    {

        public long ID { get; set; }

        public long CreatedByID { get; set; }
        public DateTime CreatedDate { get; set; }

        public long LastModifiedByID { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string IPAddress { get; set; }

        public string CreatedByUserNameAr { get; set; }
        public string CreatedByUserNameEn { get; set; }

        public string LastModifiedByNameAr { get; set; }
        public string LastModifiedByNameEn { get; set; }
    }
}
