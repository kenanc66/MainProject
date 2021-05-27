using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Recipe : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string RecipeExplanation { get; set; }
        public string ImageUrl { get; set; }
        public string Ingredients { get; set; }
        public virtual ICollection<RecipeIngredientRelation> RecipeIngredientRelations { get; set; }

    }
}
