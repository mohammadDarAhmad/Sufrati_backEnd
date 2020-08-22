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
    [Route("api/Group")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        // GET: api/Groups
        private readonly ISufratiSupervisor _SufratiSupervisor;
        private readonly IHttpContextAccessor _accessor;

        public GroupController(ISufratiSupervisor sufratiSupervisor, IHttpContextAccessor accessor)
        {
            _SufratiSupervisor = sufratiSupervisor;
            _accessor = accessor;
        }

        // GET: api/Group
        [HttpGet]
        [Produces(typeof(GeneralGroupVM))]
        public async Task<IActionResult> Get(CancellationToken ct = default)
        {
            return Ok(await _SufratiSupervisor.GetGroups(ct));
        }

        // GET: api/Group/5
        [HttpGet("{id}", Name = "GetGroup")]
        [Produces(typeof(GroupVM))]
        public async Task<IActionResult> Get(long id, CancellationToken ct = default)
        {
            return Ok(await _SufratiSupervisor.GetGroupById(id, ct));
        }

        [HttpGet("GetGroupInfo/{id}", Name = "GetGroupInfo")]
        [Produces(typeof(BaseVM))]
        public async Task<IActionResult> GetInfo(long id, CancellationToken ct = default)
        {
            return Ok(await _SufratiSupervisor.GetGroupInformation(id, ct));
        }

        // POST: api/Group
        [HttpPost]
        [Produces(typeof(GroupVM))]
        public async Task<IActionResult> Post([FromBody] GroupVM GroupVM, CancellationToken ct = default)
        {
            var newGroup = await _SufratiSupervisor.AddGroup(GroupVM, _accessor, User, ct);
            return StatusCode(201, newGroup);
        }

        // PUT: api/Group/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, [FromBody] GroupVM GroupVM, CancellationToken ct = default)
        {
            await _SufratiSupervisor.UpdateGroup(GroupVM, _accessor, User, ct);
            return NoContent();
        }

        // DELETE: api/Group/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id, CancellationToken ct = default)
        {
            await _SufratiSupervisor.DeleteGroup(id, ct);
            return NoContent();
        }
    }
}
