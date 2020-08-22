using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Domain.ApiModels
{
    public class GeneralGroupVM
    {
        public List<GroupVMForView> Groups { get; set; }
        public List<UserInnerVM> Users { get; set; }
    }
}
