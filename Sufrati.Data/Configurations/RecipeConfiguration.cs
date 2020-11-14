using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sufrati.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sufrati.Data.Configurations
{
    public class RecipeConfiguration
    {
        public RecipeConfiguration(EntityTypeBuilder<Recipe> entity)
        {
            entity.HasIndex(e => new { e.ID }).IsUnique();
                
        }
    }
}

