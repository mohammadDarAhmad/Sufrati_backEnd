using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sufrati.Domain.ApiModels
{
    public class UserLoginVM
    {
        [Required]
        public string LoginName { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
