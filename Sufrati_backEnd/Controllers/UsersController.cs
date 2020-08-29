using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLog;
using Sufrati.Domain.ApiModels;
using Sufrati.Domain.Supervisor;
using System;
using System.Collections.Generic;
using System.IO;
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

        Logger logger = LogManager.GetCurrentClassLogger();

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
        public async Task<IActionResult> Put(long id, [FromBody] UserForViewVM userVM, CancellationToken ct = default)
        {
            await _SufratiSupervisor.UpdateUser(userVM, _accessor, User, ct);
            return NoContent();
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id, CancellationToken ct = default)
        {
            await _SufratiSupervisor.DeleteUser(id, ct);
            return NoContent();
        }
        [HttpPost("ChangePassword")]
        [Produces(typeof(ChangePassVM))]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePassVM changePassVM, CancellationToken ct = default)
        {
            await _SufratiSupervisor.ChangePassword(changePassVM, _accessor, User, ct);
            logger.Info("Password Changed successfully");
            return StatusCode(200, new JsonResult(true));

        }

        [HttpPost("ResetPassword/{userId}")]
        public async Task<IActionResult> ResetPassword(long userId, [FromBody] string newPassword, CancellationToken ct = default)
        {
            var newUser = await _SufratiSupervisor.ResetPassword(userId, newPassword, _accessor, User, ct);
            logger.Info("Password Changed successfully");
            return StatusCode(201, newUser);

            // return CreatedAtAction(nameof(Get),new { id = newUser.ID },newUser);
        }
        /// <summary>
        /// used to upload a new attachment
        /// </summary>
        /// <param name="input">file</param>
        /// <returns>AttachmentVM of the uploaded attachment</returns>
        [HttpPost("UploadUserImageAttachment")]
        [Produces(typeof(AttachmentVM))]
        public async Task<IActionResult> UploadResult(CancellationToken ct = default(CancellationToken))
        {
            if (Request.Form == null || Request.Form.Files == null || Request.Form.Files.Count == 0)
                return BadRequest();
            var file = Request.Form.Files[0];

            var result = await _SufratiSupervisor.UploadAttachmentAsync(file, _accessor, User);
            return Ok(result);

        }

        /// <summary>
        /// used to delete attachment
        /// </summary>
        [HttpDelete("DeleteUserImageAttachment/{AttachmentID}")]
        [Produces(typeof(NoContentResult))]
        public async Task<IActionResult> DeleteAttachment(long AttachmentID, CancellationToken ct = default(CancellationToken))
        {
            await _SufratiSupervisor.DeleteAttachmentAsync(AttachmentID, ct);
            return NoContent();
        }

        /// <summary>
        /// used to download an existing attachment
        /// </summary>
        /// <param name="input">AttachmentID</param>
        /// <returns>FileStream</returns>
        [HttpGet("DownloadUserImage/{AttachmentID}")]
        [Produces(typeof(FileStream))]
        public async Task<IActionResult> DownloadAttachment(long AttachmentID, CancellationToken ct = default(CancellationToken))
        {
            string storagePath = (await _SufratiSupervisor.GetSystemConstant()).AttachmentPath;

            var attachment = await _SufratiSupervisor.GetAttachmentByIDAsync(AttachmentID);
            var memory = new MemoryStream();
            var path = $"{storagePath}\\" + attachment.FilePath;

            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            var result = File(memory, "application/octet-stream", attachment.PhysicalFileName);
            return result;
        }
    }
}
