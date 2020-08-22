using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sufrati.Domain.ApiModels;
using Sufrati.Domain.Supervisor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Sufrati_backEnd.API.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/Users
        private readonly ISufratiSupervisor _SufratiSupervisor;
        private readonly IHttpContextAccessor _accessor;

        public UsersController(ISufratiSupervisor sufratiSupervisor, IHttpContextAccessor accessor)
        {
            _SufratiSupervisor = sufratiSupervisor;
            _accessor = accessor;
        }

        // GET: api/Users
        [HttpGet]
        [Produces(typeof(GeneralUserVM))]
        public async Task<IActionResult> Get(CancellationToken ct = default)
        {
            return Ok(await _SufratiSupervisor.GetUsers(ct));
        }

        // GET: api/Users/5
        [HttpGet("{id}", Name = "GetUser")]
        [Produces(typeof(UserVM))]
        public async Task<IActionResult> Get(long id, CancellationToken ct = default)
        {
            return Ok(await _SufratiSupervisor.GetUserById(id, ct));
        }

        [HttpGet("GetUserInfo/{id}", Name = "GetUserInfo")]
        [Produces(typeof(BaseVM))]
        public async Task<IActionResult> GetInfo(long id, CancellationToken ct = default)
        {
            return Ok(await _SufratiSupervisor.GetUserInformation(id, ct));
        }

        // POST: api/Users
        [HttpPost]
        [Produces(typeof(UserVM))]
        public async Task<IActionResult> Post([FromBody] UserVM UserVM, CancellationToken ct = default)
        {

            var newUser = await _SufratiSupervisor.AddUser(UserVM, _accessor, User, ct);
            return StatusCode(201, newUser);

            // return CreatedAtAction(nameof(Get),new { id = newUser.ID },newUser);
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, [FromBody] UserVM UserVM, CancellationToken ct = default)
        {
            await _SufratiSupervisor.UpdateUser(UserVM, _accessor, User, ct);
            return NoContent();
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id, CancellationToken ct = default)
        {
            await _SufratiSupervisor.DeleteUser(id, ct);
            return NoContent();
        }
    }
}
