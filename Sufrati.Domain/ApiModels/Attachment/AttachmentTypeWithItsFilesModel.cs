using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain.ApiModels
{
    public class AttachmentTypeWithItsFilesModel
    {
        public long ID { get; set; }

        public string AttachmentDescAr { get; set; }

        public string AttachmentDescEn { get; set; }

        public decimal MaxSize { get; set; }

        public List<AttachmentTypeFileTypeForAttachmentModel> FileTypes { get; set; }
    }
}
