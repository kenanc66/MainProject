using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RecipeManager : IRecipeService
    {
        IRecipeDal _recipeDal;
        //ICategoryService _categpryService;

        public RecipeManager(IRecipeDal recipeDal/*, ICategoryService categoryService*/)
        {
            _recipeDal = recipeDal;
            //_categpryService = categoryService;
        }

        public IResult Add(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        [CacheAspect]
        public IDataResult<List<Recipe>> GetAll()
        {
            
            return new SuccessDataResult<List<Recipe>>(_recipeDal.GetAll(), Messages.ProductsListed);
        }


        public IDataResult<List<Recipe>> GetAllByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Recipe> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Recipe>> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<RecipeDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<RecipeDto>>(_recipeDal.GetRecipeDetails());
        }

        public IResult Update(Recipe recipe)
        {
            throw new NotImplementedException();
        }
    }
}
