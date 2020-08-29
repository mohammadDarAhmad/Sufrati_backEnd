using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain.ApiModels
{
    public class FileTypeModel
    {
        public long ID { get; set; }

        public string FileExtension { get; set; }

        public string FileTypeDescAr { get; set; }

        public string FileTypeDescEn { get; set; }
    }
}
