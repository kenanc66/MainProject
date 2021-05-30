using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RecipeDto : IDto
    {
        
        public int RecipeID { get; set; }
        public string RecipeName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string RecipeExplanation { get; set; }
        //public List<Ingredient> Ingredient { get; set; }
        public string  Ingredients { get; set; }
        public string ImageUrl { get; set; }

    }
}
