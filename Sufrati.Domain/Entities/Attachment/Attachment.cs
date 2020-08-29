using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain.Entities
{
    public class Attachment : BaseEntity
    {
        public string FilePath { get; set; }
        public string OriginalFileName { get; set; }
        public string PhysicalFileName { get; set; }
    }
}
