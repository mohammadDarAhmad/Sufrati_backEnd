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
    [ApiController]
    public class AttachmentController : ControllerBase
    {
        private readonly ISufratiSupervisor _supervisor;
        private readonly IHttpContextAccessor _accessor;

        public AttachmentController(ISufratiSupervisor sufratiSupervisor, IHttpContextAccessor accessor)
        {
            _supervisor = sufratiSupervisor;
            _accessor = accessor;
        }

        /// <summary>
        /// used to Get All  File Types
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpGet("GetAllFileTypes")]
        [Produces(typeof(List<FileTypeModel>))]
        public async Task<IActionResult> GetAllFileTypes(CancellationToken ct = default)
        {
            return Ok(await _supervisor.GetFileTypes());
        }

        /// <summary>
        /// used to Get All Attachment Types
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpGet("GetAllAttachmentTypes")]
        [Produces(typeof(List<AttachmentTypeWithItsFilesModel>))]
        public async Task<IActionResult> GetAllAttachmentTypes(CancellationToken ct = default)
        {
            return Ok(await _supervisor.GetAttachmentTypes());
        }

        /// <summary>
        /// used to Get Attachment Type By ID
        /// </summary>
        /// <param name="id">Attachment Type ID</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Produces(typeof(AttachmentTypeWithItsFilesModel))]
        public async Task<IActionResult> GetAttachmentTypeByID(long id, CancellationToken ct = default)
        {
            return Ok(await _supervisor.GetAttachmentTypeByID(id));
        }

        [HttpGet("GetAttachmentTypeInfo/{id}", Name = "GetAttachmentTypInfo")]
        [Produces(typeof(BaseVM))]
        public async Task<IActionResult> GetAttachmentTypeInfo(long id, CancellationToken ct = default)
        {
            return Ok(await _supervisor.GetAttachmentTypeInformation(id, ct));
        }

        [HttpGet("GetFileTypeInfo/{id}", Name = "GetFileTypInfo")]
        [Produces(typeof(BaseVM))]
        public async Task<IActionResult> GetFileTypeInfo(long id, CancellationToken ct = default)
        {
            return Ok(await _supervisor.GetFileTypeInformation(id, ct));
        }

        /// <summary>
        /// Used to add Attachment Type
        /// </summary>
        /// <param name="input"></param>
        [HttpPost("PostAttachmentType")]
        [Produces(typeof(AttachmentTypeWithItsFilesModel))]
        public async Task<IActionResult> PostAttachmentType([FromBody][Required] AttachmentTypesWithFilesForPostModel input, CancellationToken ct = default)
        {
            return Created("", await _supervisor.AddAttachment(input, _accessor, User, ct));
        }

        /// <summary>
        /// Used to add a File Types 
        /// </summary>
        /// <param name="input"></param>
        [HttpPost("AddFileType")]
        [Produces(typeof(FileTypeModel))]
        public async Task<IActionResult> AddFileType([FromBody][Required] FileTypeModel input, CancellationToken ct = default)
        {
            return Created("", await _supervisor.AddFileType(input, _accessor, User, ct));
        }

        /// <summary>
        /// Used to update Attachment Type
        /// </summary>
        /// <param name="input"></param>
        [HttpPut("UpdateAttachmentType")]
        [Produces(typeof(AttachmentTypeWithItsFilesModel))]
        public async Task<IActionResult> UpdateAttachmentType([FromBody][Required] AttachmentTypesWithFilesForPostModel input, CancellationToken ct = default)
        {
            return Created("", await _supervisor.UpdateAttachment(input, _accessor, User, ct));
        }

        /// <summary>
        /// Used to update a File Types 
        /// </summary>
        /// <param name="input"></param>
        [HttpPut("UpdateFileType")]
        [Produces(typeof(FileTypeModel))]
        public async Task<IActionResult> UpdateFileType([FromBody][Required] FileTypeModel input, CancellationToken ct = default)
        {
            return Created("", await _supervisor.UpdateFileType(input, _accessor, User, ct));
        }

        /// <summary>
        /// used to delete a file type
        /// </summary>
        /// <param name="id">file type ID</param>
        /// <returns>NoContentResult</returns>
        [HttpDelete("DeleteFileType/{id}")]
        [Produces(typeof(NoContentResult))]
        public async Task<IActionResult> DeleteFileType(long id, CancellationToken ct = default)
        {
            await _supervisor.DeleteFileTypeByID(id, ct);
            return NoContent();
        }

        /// <summary>
        /// used to delete an Attachment type
        /// </summary>
        /// <param name="id">Attachment type ID</param>
        /// <returns>NoContentResult</returns>
        [HttpDelete("DeleteAttachmentType/{id}")]
        [Produces(typeof(NoContentResult))]
        public async Task<IActionResult> DeleteAttachmentType(long id, CancellationToken ct = default)
        {
            await _supervisor.DeleteAttachmentTypeByID(id, ct);
            return NoContent();
        }
    }
}