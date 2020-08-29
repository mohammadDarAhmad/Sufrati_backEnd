using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain.ApiModels
{
    public class AttachmentVM
    {
        public long ID { get; set; }
        public string FilePath { get; set; }
        public string OriginalFileName { get; set; }
        public string PhysicalFileName { get; set; }
    }
}
