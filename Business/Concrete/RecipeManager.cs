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
            _recipeDal.Add(recipe);
            return new SuccessResult(Messages.RecipeAdded);

        }

        [CacheAspect]
        public IDataResult<List<Recipe>> GetAll()
        {
            
            return new SuccessDataResult<List<Recipe>>(_recipeDal.GetAll(), Messages.ProductsListed);
        }


        
        public IDataResult<List<Recipe>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Recipe>>
                (_recipeDal.GetAll(p => p.CategoryId == id),"sa");
        }
        public IDataResult<List<RecipeDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<RecipeDto>>(_recipeDal.GetRecipeDetails());
        }
        public IDataResult<Recipe> GetById(int Id)
        {
            return new SuccessDataResult<Recipe>
                 (_recipeDal.Get(p => p.Id == Id));

        }

        

       

        public IResult Update(Recipe recipe)
        {
            return new SuccessResult("updated");
        }

       
    }
}
