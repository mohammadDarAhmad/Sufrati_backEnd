using Microsoft.AspNetCore.Http;
using Sufrati.Domain.ApiModels;
using Sufrati.Domain.Entities;
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
        public async Task<bool> AddRecipe(RecipeVM recipeVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default)
        {
          var recipe=   _Mapper.Map<RecipeVM, Recipe>(recipeVM);
          
            try
            {
                GeneralMethod.AddBaseProperties(recipe, accessor, user, false);

                return await _RecipeRepository.AddRecipe(recipe, ct);
            }
            catch(Exception ex)
            {
                return false;
            }
        }


       
    }
}
