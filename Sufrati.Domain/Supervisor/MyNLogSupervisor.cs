using Microsoft.AspNetCore.Http;
using Sufrati.Domain.ApiModels;
using Sufrati.Domain.Entities;
using Sufrati.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sufrati.Domain.Supervisor
{
    public partial class SufratiSupervisor : ISufratiSupervisor

    {
        public async Task<List<GeneralLookupInnerValueVM>> GetLogTypes(CancellationToken ct = default)
    {
        var result = await _LookupRepository.GetLookupValueByTypeId(105000000000019);
        return _Mapper.Map<List<GeneralLookupInnerValueVM>>(result);
    }

    public async Task<List<MyNLogVM>> GetLoogerBetweentwoDatesAndType(DateTime fromDate, DateTime toDate, long logTypeID, CancellationToken ct = default)
    {
        var result = await _IMyNLogRepository.GetBetweentwoDatesAndType(fromDate, toDate, logTypeID);
        List<MyNLogVM> myNLogVMs = new List<MyNLogVM>();
        foreach (var entity in result)
        {
            var mapped = _Mapper.Map<MyNLogVM>(entity);
            mapped.LogDate = entity.LogDate.ToString("yyyy-MM-dd-HH:mm:ss");
            if (entity.LogoutTime.HasValue)
            {
                mapped.LogoutTime = entity.LogoutTime.Value.ToString("yyyy-MM-dd-HH:mm:ss");
            }
            myNLogVMs.Add(mapped);
        }
        return myNLogVMs;
    }


    public List<LogerTypesAndColumnsVM> GetLoogerTypeColumns()
    {
        List<LogerTypesAndColumnsVM> logerTypesAndColumnsVM = new List<LogerTypesAndColumnsVM>();

        logerTypesAndColumnsVM.Add(
            new LogerTypesAndColumnsVM()
            {
                ID = LookupsValuesConstants.ErrorLogType,
                Columns = new List<LoogerColumnsVM>()
                {

                        new LoogerColumnsVM()
                        {
                            Property = "logDate",
                            ColumnNameAR ="وقت الحدث",
                            ColumnNameEN = "Logger Time"
                        },
                        new LoogerColumnsVM()
                        {
                            Property = "ipAddress",
                            ColumnNameAR ="عنوان الاي بي",
                            ColumnNameEN = "IP Address"
                        },
                        new LoogerColumnsVM()
                        {
                            Property = "nameEn",
                            ColumnNameAR ="اسم المستخدم",
                            ColumnNameEN = "User Name"
                        },
                        new LoogerColumnsVM()
                        {
                            Property = "requestURL",
                            ColumnNameAR ="الرابط",
                            ColumnNameEN = "Request URL"
                        },
                        new LoogerColumnsVM()
                        {
                            Property = "action",
                            ColumnNameAR ="العملية",
                            ColumnNameEN = "Action"
                        },
                        new LoogerColumnsVM()
                        {
                            Property = "entityName",
                            ColumnNameAR ="المصدر",
                            ColumnNameEN = "Resource"
                        },
                        new LoogerColumnsVM()
                        {
                            Property = "exceptionType",
                            ColumnNameAR ="نوع الخطأ",
                            ColumnNameEN = "Exception Type"
                        },
                        new LoogerColumnsVM()
                        {
                            Property = "exceptionMessages",
                            ColumnNameAR ="رسالة الخطأ",
                            ColumnNameEN = "Exception Messages"
                        },
                        new LoogerColumnsVM()
                        {
                            Property = "messagesCode",
                            ColumnNameAR ="رمز الرسالة",
                            ColumnNameEN = "Messages Code"
                        },
                        new LoogerColumnsVM()
                        {
                            Property = "additionalInfo",
                            ColumnNameAR ="معلومات اضافية",
                            ColumnNameEN = "Additional Info"
                        }
                }
            });

        logerTypesAndColumnsVM.Add(
        new LogerTypesAndColumnsVM()
        {
            ID = LookupsValuesConstants.LoginHistoryLogType,
            Columns = new List<LoogerColumnsVM>()
            {
                       new LoogerColumnsVM()
                        {
                            Property = "logDate",
                            ColumnNameAR ="وقت الحدث",
                            ColumnNameEN = "Logger Time"
                        },
                        new LoogerColumnsVM()
                        {
                            Property = "ipAddress",
                            ColumnNameAR ="عنوان الاي بي",
                            ColumnNameEN = "IP Address"
                        },
                        new LoogerColumnsVM()
                        {
                            Property = "nameEn",
                            ColumnNameAR ="اسم المستخدم",
                            ColumnNameEN = "User Name"
                        },
                        new LoogerColumnsVM()
                        {
                            Property = "requestURL",
                            ColumnNameAR ="الرابط",
                            ColumnNameEN = "Request URL"
                        },
                        new LoogerColumnsVM()
                        {
                            Property = "action",
                            ColumnNameAR ="العملية",
                            ColumnNameEN = "Action"
                        },
                        new LoogerColumnsVM()
                        {
                            Property = "entityName",
                            ColumnNameAR ="المصدر",
                            ColumnNameEN = "Resource"
                        },
                        new LoogerColumnsVM()
                        {
                            Property = "logoutTime",
                            ColumnNameAR ="وقت تسجيل الخروج",
                            ColumnNameEN = "Logout Time"
                        },
                        new LoogerColumnsVM()
                        {
                            Property = "token",
                            ColumnNameAR ="الرمز",
                            ColumnNameEN = "Token"
                        }
            }
        }); logerTypesAndColumnsVM.Add(
                new LogerTypesAndColumnsVM()
                {
                    ID = LookupsValuesConstants.ChangePasswordHistoryLogType,
                    Columns = new List<LoogerColumnsVM>()
                    {
                        new LoogerColumnsVM()
                        {
                            Property = "logDate",
                            ColumnNameAR ="وقت الحدث",
                            ColumnNameEN = "Logger Time"
                        },
                        new LoogerColumnsVM()
                        {
                            Property = "ipAddress",
                            ColumnNameAR ="عنوان الاي بي",
                            ColumnNameEN = "IP Address"
                        },
                        new LoogerColumnsVM()
                        {
                            Property = "nameEn",
                            ColumnNameAR ="اسم المستخدم",
                            ColumnNameEN = "User Name"
                        },
                        new LoogerColumnsVM()
                        {
                            Property = "requestURL",
                            ColumnNameAR ="الرابط",
                            ColumnNameEN = "Request URL"
                        },
                        new LoogerColumnsVM()
                        {
                            Property = "action",
                            ColumnNameAR ="العملية",
                            ColumnNameEN = "Action"
                        },
                        new LoogerColumnsVM()
                        {
                            Property = "entityName",
                            ColumnNameAR ="المصدر",
                            ColumnNameEN = "Resource"
                        },
                        new LoogerColumnsVM()
                        {
                            Property = "nameEn",
                            ColumnNameAR ="تم تغيير كلمة المرور بواسطة",
                            ColumnNameEN = "Password Changed By"
                        }
                    }
                });


        return logerTypesAndColumnsVM;
    }

    public async Task MyNlogLogoutProperety(string token, CancellationToken ct = default)
    {
        await _IMyNLogRepository.AddLogoutValue(token);
    }

}
}
