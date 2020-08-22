using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain.ApiModels
{
    public class GeneralUserVM
    {
        public List<UserVMForView> Users { get; set; }
        public List<PasswordPolicyInnerVM> PasswordPolicies { get; set; }
        public List<GeneralLookupValueVM> UserTypes { get; set; }
    }
}
