using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain.ApiModels
{
    public class UserDetailsVM
    {
        public UserVM User { get; set; }
        public List<PasswordPolicyVM> PasswordPolicies { get; set; }
        public List<GeneralLookupValueVM> UserTypes { get; set; }
    }
}
