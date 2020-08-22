using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain.ApiModels
{
    public class UserVM 
    {
        public long ID { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }

        public long UserTypeID { get; set; }
        public string Email { get; set; }
        public string HomePhone { get; set; }

        public string Mobile { get; set; }

        public string Address { get; set; }

        public string Notes { get; set; }
        public bool IsActive { get; set; }


        public long PasswordPolicyID { get; set; }
        public string UserImageOriginal { get; set; }
        public string UserImageSmall { get; set; }


        public GeneralLookupInnerValueVM UserType { get; set; }
        public PasswordPolicyVMForView PasswordPolicy { get; set; }


    }
}
