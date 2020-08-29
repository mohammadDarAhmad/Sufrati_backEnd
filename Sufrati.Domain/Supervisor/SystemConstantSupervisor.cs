using Microsoft.AspNetCore.Http;
using Sufrati.Domain.ApiModels;
using Sufrati.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sufrati.Domain.Supervisor
{
    public partial class SufratiSupervisor : ISufratiSupervisor

    {

        public async Task<SystemConstantGetVM> GetSystemConstant(CancellationToken ct = default)
        {

            var result = await _SystemConstantRepository.GetSystemConstant(ct);

            var weekend = result.Weekend;

            SystemConstantGetVM systemConstantGetVM = new SystemConstantGetVM()
            {
                ID = result.ID,
                NotifyBanksForInvoiceAfter = result.NotifyBanksForInvoiceAfter,
                MaxCompensationAmount = result.MaxCompensationAmount,
                QualitativeCriteriaMaxScore = result.QualitativeCriteriaMaxScore,
                TotalQuantitativeCriteriaMaxScore = result.TotalQuantitativeCriteriaMaxScore,
                OutgoingSMTPServer = result.OutgoingSMTPServer,
                SMTPServerRequiresAuthentication = result.SMTPServerRequiresAuthentication,
                Username = result.Username,
                Password = result.Password,
                FormEmailAddress = result.FormEmailAddress,
                EnableSSL = result.EnableSSL,
                SMTPPortNumber = result.SMTPPortNumber,
                FinesAmountPerEachDayDelayed = result.FinesAmountPerEachDayDelayed,

                AttachmentPath = result.AttachmentPath,
            };

            return systemConstantGetVM;
        }
        public async Task<BaseVM> GetSystemConstantInformation(CancellationToken ct = default)
        {
            var result = await _SystemConstantRepository.GetSystemConstantInformation(ct);
            return result;
        }
        public async Task<bool> UpdateSystemConstant(SystemConstantVM systemConstantVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default)
        {
            var systemConst = _Mapper.Map<SystemConstantVM, SystemConstant>(systemConstantVM);
            GeneralMethod.AddBaseProperties<SystemConstant>(systemConst, accessor, user, false);
            return await _SystemConstantRepository.UpdateSystemConstant(systemConst, ct);
        }


    }
}
