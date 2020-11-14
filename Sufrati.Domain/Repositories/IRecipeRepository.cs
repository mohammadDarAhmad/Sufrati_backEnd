using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Sufrati.Domain.Entities;
using Sufrati.Domain.ApiModels;

namespace Sufrati.Domain.Repositories
{
    public interface IRecipeRepository
    {
        Task<bool> AddRecipe(Recipe recipe, CancellationToken ct = default);

    }
}
