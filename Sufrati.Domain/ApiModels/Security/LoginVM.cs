using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sufrati.Domain.ApiModels
{
    public class LoginVM
    {
        public string token { get; set; }
        public UserInnerVM userDetails { get; set; }
        public List<long> action { get; set; }
    }
}
