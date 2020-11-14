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
        // GET: api/Recipe
        [HttpPost]

        public async Task<IActionResult> Add(RecipeVM recipe, CancellationToken ct = default)
        {

           if( await _SufratiSupervisor.AddRecipe(recipe, _accessor, User, ct))
            {
                return StatusCode(201);
            }
            return StatusCode(400);
        }
    }

}
