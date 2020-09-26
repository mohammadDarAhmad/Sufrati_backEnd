using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain.ApiModels
{
    public class AuditLogVM
    {
        public string ColumnName { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }
    }
}
