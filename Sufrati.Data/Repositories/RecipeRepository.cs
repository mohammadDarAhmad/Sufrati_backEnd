using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
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
        public async Task<List<Recipe>> GetRecipe(CancellationToken ct = default)
        {
            return await _context.Recipe.ToListAsync(ct);
        }
        public async Task<bool> AddRecipe(Recipe recipe, CancellationToken ct = default)
        {
          
                _context.Recipe.Add(recipe);
                await _context.SaveChangesAsync(ct);          
            return true;
        }

        public async Task<Recipe> GetRecipeById(long id, CancellationToken ct = default)
        {
            var result = await _context.Recipe.SingleOrDefaultAsync(b => b.ID == id); ;
            return result;
        }

        public async Task<bool> DeleteRecipe(long id, CancellationToken ct = default)
        {
            var Obj = await GetRecipeById(id, ct);
            _context.Recipe.Remove(Obj);
            await _context.SaveChangesAsync(ct);
            return true;
        }

        public async Task<bool> UpdateRecipe(Recipe recipe, CancellationToken ct = default)
        {
            try
            {
                var update = await _context.Recipe.FirstAsync(g => g.ID == recipe.ID);
                _context.Entry(update).CurrentValues.SetValues(recipe);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                return false;

            }
            return true;
        }
    }


}
