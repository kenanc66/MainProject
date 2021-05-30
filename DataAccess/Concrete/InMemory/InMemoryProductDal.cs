using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IRecipeDal
    {
        List<Recipe> _products;
        public InMemoryProductDal()
        {
            _products = new List<Recipe> {
            new Recipe{Id=1,CategoryId=1,Name="Bardak"},
            new Recipe{Id=2,CategoryId=1,Name="a"},
            new Recipe{Id=3,CategoryId=1,Name="b"},
            new Recipe{Id=4,CategoryId=1,Name="c"},
            new Recipe{Id=5,CategoryId=1,Name="d"},
            };
        }
        public void Add(Recipe recipe)
        {
            _products.Add(recipe);
        }

        public void Delete(Recipe recipe)
        {//LINQ language integrated query
            Recipe productToDelete = _products.SingleOrDefault(p=>p.Id==recipe.Id);
           _products.Remove(productToDelete);
        }

        public Recipe Get(Expression<Func<Recipe, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Recipe> GetAll()
        {
            return _products;
        }

        public List<Recipe> GetAll(Expression<Func<Recipe, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Recipe> GetAllByCategory(int categoryId)
        {
          return  _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<RecipeDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public List<RecipeDto> GetRecipeDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Recipe product)
        {
            Recipe productToUpdate = _products.SingleOrDefault(p => p.Id == product.Id);
            productToUpdate.Name = product.Name;
            productToUpdate.CategoryId = product.CategoryId;
            

        }
    }
}
