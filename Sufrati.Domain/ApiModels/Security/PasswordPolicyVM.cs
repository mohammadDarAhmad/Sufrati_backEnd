using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain.ApiModels
{
    public class PasswordPolicyVM
    {
        public long ID { get; set; }
        public bool FirstLoginChangePassword { get; set; }
        public string TitleAr { get; set; }
        public string TitleEn { get; set; }
        public int MinLength { get; set; }
        public int SessionAfterEnd { get; set; }
        public int SuspendPasswordAfter { get; set; }
        public bool IncludeSpecialCharacter { get; set; }
        public bool IncludeNumeric { get; set; }
        public bool IncludeCharacter { get; set; }

    }
}
