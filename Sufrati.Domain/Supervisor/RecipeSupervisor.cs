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
     
        public async Task<List<RecipeVM>> GetAllRecipe(CancellationToken ct = default)
        {

           var recipes =  await _RecipeRepository.GetRecipe(ct);
            var result = _Mapper.Map<List<RecipeVM>>(recipes);

            return result;

        }
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
        public async Task<RecipeVM> GetRecipeByID(long id, CancellationToken ct = default)
        {
         var recpie =  await  _RecipeRepository.GetRecipeById(id, ct);

            var recpieVM = _Mapper.Map<Recipe, RecipeVM>(recpie);
            return recpieVM;
        }
        public async Task<bool> UpdateRecipe(RecipeVM recipeVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default)
        {
            var recipe = _Mapper.Map<RecipeVM, Recipe>(recipeVM);
            GeneralMethod.AddBaseProperties<Recipe>(recipe, accessor, user, false);       
            return await _RecipeRepository.UpdateRecipe(recipe, ct);
        }

        public async Task<bool> DeleteRecipe(long id, CancellationToken ct = default)
        {
            return await _RecipeRepository.DeleteRecipe(id, ct);

        }
    }
}
