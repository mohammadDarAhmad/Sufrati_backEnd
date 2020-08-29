using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain.ApiModels
{
    public class AttachmentTypeFileTypeModel
    {
        public long AttachmentTypeID { get; set; }

        public long FileTypeID { get; set; }

        public AttachmentTypeModel AttachmentType { get; set; }
        public FileTypeModel FileType { get; set; }
    }
}
