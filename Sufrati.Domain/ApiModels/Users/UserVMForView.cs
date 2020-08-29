using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain.ApiModels
{
    public class UserVMForView
    {
        public long ID { get; set; }
        public string LoginName { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public long UserTypeID { get; set; }
        public bool IsActive { get; set; }
        public long PasswordPolicyID { get; set; }
        public GeneralLookupInnerValueVM UserType { get; set; }
        public PasswordPolicyVM PasswordPolicy { get; set; }

    }
}
