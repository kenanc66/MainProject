using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRecipeService
    {
        IDataResult<List<Recipe>> GetAll();
        IDataResult<List<Recipe>> GetAllByCategoryId(int id);
        IDataResult<List<Recipe>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<RecipeDto>> GetProductDetails();
        IResult Add(Recipe recipe);
        IResult Update(Recipe recipe);
        IDataResult<Recipe> GetById(int Id);
        
    }
}
