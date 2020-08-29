using Microsoft.EntityFrameworkCore;
using Sufrati.Domain.ApiModels;
using Sufrati.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sufrati.Data
{
    public static class GeneralMethod
    {
        public static async Task<BaseVM> GenerateInfoModel(BaseEntity baseEntity, SufratiContext context)
        {
            var userInfo = await context.User.Where(u => u.ID == baseEntity.CreatedByID || u.ID == baseEntity.LastModifiedByID).ToListAsync();

            BaseVM infoVM = new BaseVM();
            var created = userInfo.Where(u => u.ID == baseEntity.CreatedByID).FirstOrDefault();
            var modified = userInfo.Where(u => u.ID == baseEntity.LastModifiedByID).FirstOrDefault();
            if (created != null)
            {
                infoVM.CreatedByID = created.ID;
                infoVM.CreatedByUserNameAr = created.NameAr;
                infoVM.CreatedByUserNameEn = created.NameEn;

            }
            if (modified != null)
            {
                infoVM.LastModifiedByID = modified.ID;
                infoVM.LastModifiedByNameAr = modified.NameAr;
                infoVM.LastModifiedByNameEn = modified.NameEn;
            }
            infoVM.ID = baseEntity.ID;
            infoVM.CreatedDate = (DateTime)baseEntity.CreatedDate;
            infoVM.LastModifiedDate = (DateTime)baseEntity.LastModifiedDate;
            infoVM.IPAddress = baseEntity.IPAddress;

            return infoVM;
        }


    }
}
