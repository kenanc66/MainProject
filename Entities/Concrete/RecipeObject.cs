using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class RecipeObject : IEntity
    {
        public int Id { get; set; }
        public int RecipeID { get; set; }
        public string RecipeName { get; set; }
        public string RecipeExplanation { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Ingredients { get; set; }
        public int IngredientID { get; set; }
        public string IngredientsName { get; set; }
    }
}
