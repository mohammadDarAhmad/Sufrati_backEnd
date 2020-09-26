using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain.ApiModels
{
    public class NewAuditLogVM
    {
        public long ID { get; set; }

        public UserInnerVM ModifiedBy { get; set; }

        //public EntityVM Entity { get; set; }

        public string OperationType { get; set; }

        public string Date { get; set; }

        public long ItemID { get; set; }

        public string IPAddress { get; set; }

        public List<AuditLogVM> Columns { get; set; }
    }
}
