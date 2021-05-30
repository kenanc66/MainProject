using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRecipeDal : EfEntityRepositoryBase<Recipe, NorthwindContext>, IRecipeDal
    {
        List<RecipeDto> IRecipeDal.GetRecipeDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {

                var result = from p in context.Recipes
                             join c in context.Categories
                                on p.CategoryId equals c.Id


                             select new RecipeDto
                             {
                                 RecipeID = p.Id,
                                 RecipeName = p.Name,
                                 Ingredients = p.Ingredients,
                                 RecipeExplanation = p.RecipeExplanation,

                                 ImageUrl = "https://localhost:44396/api/recipes/get/" + p.ImageUrl,
                                 CategoryId = p.CategoryId,
                                 CategoryName = c.Name,


                             };
                return result.ToList();
            }

        }
        //public void Add(Recipe entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(Recipe entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Recipe Get(Expression<Func<Recipe, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Recipe> GetAll(Expression<Func<Recipe, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}



        //public List<RecipeObject> GetRecipeDetails()
        //{
        //    using (NorthwindContext context = new NorthwindContext())
        //    {

        //        var result = from p in context.Recipes
        //                     join c in context.Categories
        //                        on p.CategoryId equals c.Id


        //                     select new RecipeObject
        //                     {
        //                         RecipeID = p.Id,
        //                         RecipeName = p.Name,
        //                         Ingredients = p.Ingredients,
        //                         RecipeExplanation = p.RecipeExplanation,

        //                         ImageUrl = p.ImageUrl,
        //                         CategoryId = p.CategoryId,
        //                         CategoryName = c.Name,


        //                     };
        //        return  result.ToList();
        //    }

        //}

        //public void Update(Recipe entity)
        //{
        //    throw new NotImplementedException();
        //}


    } 
}


