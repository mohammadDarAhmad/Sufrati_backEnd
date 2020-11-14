using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Sufrati.Domain.ApiModels;
using Sufrati.Domain.Supervisor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Sufrati_backEnd.API.Controllers
{
    [Route("api/[controller]")]
    public class LookupController : Controller
    {
        private readonly ISufratiSupervisor _SufratiSupervisor;
        private readonly IHttpContextAccessor _accessor;
        private readonly string _connectionString;

        public LookupController(ISufratiSupervisor sufratiSupervisor, IConfiguration configuration, IHttpContextAccessor accessor)
        {
            _SufratiSupervisor = sufratiSupervisor;
            _connectionString = configuration.GetConnectionString("PCPS_CS");
            _accessor = accessor;
        }

        /// <summary>
        /// used to get all Lookups
        /// </summary>
        /// <returns>GeneralLookupsVM</returns>        
        // GET: api/Default
        [HttpGet]
        [Produces(typeof(GeneralLookupsVM))]
        public async Task<IActionResult> Get(CancellationToken ct = default)
        {
            return Ok(await _SufratiSupervisor.GetGeneralLookupsVM(ct));
        }

        /// <summary>
        /// used to Get Lookup by id
        /// </summary>
        /// <param name="id">the id of the Lookup</param>
        /// <returns>GeneralLookupsVM</returns>
        [HttpGet("{id}")]
        [Produces(typeof(GeneralLookupsVM))]
        public async Task<IActionResult> Get(long id, CancellationToken ct = default)
        {
            return Ok(await _SufratiSupervisor.GetLookupValue(id));
        }

        /// <summary>
        /// used to add new Lookup
        /// </summary>
        /// <param name="input">GeneralLookupValueVM</param>
        /// <returns>GeneralLookupValueVM of the added Lookup</returns>
        [HttpPost]
        [Produces(typeof(GeneralLookupValueVM))]
        public async Task<IActionResult> Post([FromBody][Required] GeneralLookupValueVM input, CancellationToken ct = default)
        {
            return Created("", await _SufratiSupervisor.AddGeneralLookup(input, _accessor, User, ct));
        }

        /// <summary>
        /// used to update a Lookup
        /// </summary>
        /// <param name="input">GeneralLookupValueVM</param>
        /// <returns>GeneralLookupValueVM of the updated Lookup</returns>
        [HttpPut]
        [Produces(typeof(GeneralLookupsVM))]
        public async Task<IActionResult> Put([FromBody][Required] GeneralLookupValueVM input, CancellationToken ct = default)
        {
            return Ok(await _SufratiSupervisor.UpdateGeneralLookupAsync(input, _accessor, User, ct));
        }

        /// <summary>
        /// used to delete a Lookup
        /// </summary>
        /// <param name="id">Lookup ID</param>
        /// <returns>NoContentResult</returns>
        [HttpDelete("{id}")]
        [Produces(typeof(NoContentResult))]
        public async Task<IActionResult> Delete(long id, CancellationToken ct = default)
        {
            await _SufratiSupervisor.DeleteGeneralLookupAsync(id, ct);
            return NoContent();
        }


        /// <summary>
        /// used to get More information about the lookup value
        /// </summary>
        /// <param name="id">Lookup ID</param>
        /// <returns>OkResult</returns>
        [HttpGet("GetInfo/{id}")]
        [Produces(typeof(BaseVM))]
        public async Task<IActionResult> GetInfo(long id, CancellationToken ct = default)
        {
            return Ok(await _SufratiSupervisor.GetLookupInformation(id, ct));
        }

      
        ///// <summary>
        ///// used to export Data To Excel File
        ///// </summary>
        ///// <returns>FileStream</returns>
        //[HttpGet("ExportToExel")]
        //[Produces(typeof(FileStream))]
        //public async Task<IActionResult> ExportToEexcelAsync(CancellationToken ct = default)
        //{
        //    DateTime now = DateTime.Now;
        //    var FileName = "GeneralLookupValue" + now.ToString("yyyyMMddHHmmss") + "." + "xlsx";
        //    var stream = await GeneralMethod.ExportToExcel(_connectionString, "GeneralLookupValue", ct);

        //    var result = File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", FileName);

        //    return result;
        //}

        ///// <summary>
        ///// used to export Data To PDF File
        ///// </summary>
        ///// <returns>FileStream</returns>
        //[HttpGet("ExportToPDF")]
        //[Produces(typeof(FileStream))]
        //public async Task<IActionResult> ExportToPdf(CancellationToken ct = default)
        //{
        //    DateTime now = DateTime.Now;
        //    var FileName = "GeneralLookupValue" + now.ToString("yyyyMMddHHmmss") + "." + "pdf";
        //    var stream = await GeneralMethod.ExportToPDF(_connectionString, "GeneralLookupValue", ct);

        //    var result = File(stream, "application/pdf", FileName);

        //    return result;


        //}

    }
}
