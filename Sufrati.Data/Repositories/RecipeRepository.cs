using Sufrati.Domain.ApiModels;
using Sufrati.Domain.Entities;
using Sufrati.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sufrati.Data.Repositories
{
        public class RecipeRepository : IRecipeRepository
        {
        private readonly SufratiContext _context;
        public RecipeRepository(SufratiContext context)
        {
            _context = context;
        }

        public async Task<bool> AddRecipe(Recipe recipe, CancellationToken ct = default)
        {
          
                _context.Recipe.Add(recipe);
                await _context.SaveChangesAsync(ct);          
            return true;
        }
    }   
}
