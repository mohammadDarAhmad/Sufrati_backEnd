using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain.ApiModels
{

    public class TokenDetailVM
    {
        public string Token { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string ExpiryDate { get; set; }
    }


}