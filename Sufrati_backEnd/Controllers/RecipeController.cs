using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Sufrati.Domain.ApiModels;
using Sufrati.Domain.Entities;
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
    [Route("api/Recipe")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly ISufratiSupervisor _SufratiSupervisor;
        private readonly IHttpContextAccessor _accessor;

        public RecipeController(ISufratiSupervisor sufratiSupervisor, IHttpContextAccessor accessor)
        {
            _SufratiSupervisor = sufratiSupervisor;
            _accessor = accessor;
        }
        // GET: api/Recipe/
        [HttpGet("GetAllRecipe")]
        [Produces(typeof(List<RecipeVM>))]
        public async Task<IActionResult> GetAllRecipe(CancellationToken ct = default)
        {
            return Ok(await _SufratiSupervisor.GetAllRecipe(ct));
        }

        // GET: api/Recipe/5
        [HttpGet("{id}", Name = "GetRecipe")]
        [Produces(typeof(RecipeVM))]
        public async Task<IActionResult> Get(long id, CancellationToken ct = default)
        {
            return Ok(await _SufratiSupervisor.GetRecipeByID(id, ct));
        }
        // Post: api/Recipe/Add
        [HttpPost]

        public async Task<IActionResult> Post(RecipeVM recipe, CancellationToken ct = default)
        {

           if( await _SufratiSupervisor.AddRecipe(recipe, _accessor, User, ct))
            {
                return StatusCode(201);
            }
            return StatusCode(400);
        }   // PUT: api/Recipe/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, [FromBody] RecipeVM userVM, CancellationToken ct = default)
        {

          await _SufratiSupervisor.UpdateRecipe(userVM, _accessor, User, ct);
         
            return NoContent();
        }

        // DELETE: api/Recipe/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id, CancellationToken ct = default)
        {
            
            var isDeleted = await _SufratiSupervisor.DeleteRecipe(id, ct);
            if (isDeleted)
            {
                return NoContent();

            }
            return BadRequest();//statuse code 400
        }


    }


}
