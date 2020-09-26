using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain.ApiModels
{
    public class MyNLogVM
    {
        public long ID { get; set; }

        public string LogDate { get; set; }
      
        public string IPAddress { get; set; }

        public string RequestURL { get; set; }

        public string Action { get; set; }
       
        public long LogTypeID { get; set; }

        public string ExceptionType { get; set; }

        public string ExceptionMessages { get; set; }

        public string MessagesCode { get; set; }

        public string AdditionalInfo { get; set; }

        public string LogoutTime { get; set; }

        public string Token { get; set; }

        public UserInnerVM User { get; set; }
        public UserInnerVM PasswordChangedByUser { get; set; }
        public GeneralLookupInnerValueVM LogType { get; set; }
        //public EntityVM Entity { get; set; }
    }
}
