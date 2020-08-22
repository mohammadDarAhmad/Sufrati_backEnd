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
    [Route("api/PasswordPolicies")]
    [ApiController]
    public class PasswordPoliciesController : ControllerBase
    {
        // GET: api/PasswordPolicies

        private readonly ISufratiSupervisor _SufratiSupervisor;
        private readonly IHttpContextAccessor _accessor;

        public PasswordPoliciesController(ISufratiSupervisor sufratiSupervisor, IHttpContextAccessor accessor)
        {
            _SufratiSupervisor = sufratiSupervisor;
            _accessor = accessor;
        }

        // GET: api/PasswordPolicies
        [HttpGet]
        [Produces(typeof(List<PasswordPolicyVM>))]
        public async Task<IActionResult> Get(CancellationToken ct = default)
        {
            return Ok(await _SufratiSupervisor.GetPasswordPolicys(ct));
        }

        // GET: api/PasswordPolicies/5
        [HttpGet("{id}", Name = "GetPasswordPolicy")]
        [Produces(typeof(PasswordPolicyVM))]
        public async Task<IActionResult> Get(long id, CancellationToken ct = default)
        {
            return Ok(await _SufratiSupervisor.GetPasswordPolicyById(id, ct));
        }

        [HttpGet("GetPasswordPolicyInfo/{id}", Name = "GetPasswordPolicyInfo")]
        [Produces(typeof(BaseVM))]
        public async Task<IActionResult> GetInfo(long id, CancellationToken ct = default)
        {
            return Ok(await _SufratiSupervisor.GetPasswordPolicyInformation(id, ct));
        }

        // POST: api/PasswordPolicies
        [HttpPost]
        [Produces(typeof(PasswordPolicyVM))]
        public async Task<IActionResult> Post([FromBody] PasswordPolicyVM PasswordPolicyVM, CancellationToken ct = default)
        {
            var newPasswordPolicy = await _SufratiSupervisor.AddPasswordPolicy(PasswordPolicyVM, _accessor, User, ct);
            return StatusCode(201, newPasswordPolicy);
        }

        // PUT: api/PasswordPolicies/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, [FromBody] PasswordPolicyVM PasswordPolicyVM, CancellationToken ct = default)
        {
            await _SufratiSupervisor.UpdatePasswordPolicy(PasswordPolicyVM, _accessor, User, ct);
            return NoContent();
        }

        // DELETE: api/PasswordPolicies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id, CancellationToken ct = default)
        {
            await _SufratiSupervisor.DeletePasswordPolicy(id, ct);
            return NoContent();
        }
    }
}
