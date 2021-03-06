using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager //: IProductService
    {
    //    IProductDal _productDal;
    //    ICategoryService _categpryService;


    //    public ProductManager(IProductDal productDal,ICategoryService categoryService)
    //    {
    //        _productDal = productDal;
    //        _categpryService = categoryService;
    //    }
    //    [SecuredOperation("admin")]
    //    [CacheRemoveAspect("IProductService.Get")]
    //    [ValidationAspect(typeof(ProductValidator))]
    //    //[SecuredOperation("product.add,admin")]
    //    public IResult Add(Product product)
    //    {
    //        IResult result = BusinessRules.Run(
    //              CheckIfProductCountOfCategoryCorrect(product.CategoryId),
    //              CheckIfProductNameExists(product.ProductName),
    //              CheckIfCategoryLimitExceeded());
    //        if (result!=null)
    //        {
    //            return result;
    //        }
    //        _productDal.Add(product);
    //        return new SuccessResult(Messages.ProductAdded);
    //    }
    //    [CacheAspect]
    //    public IDataResult<List<Product>> GetAll()
    //    {
    //        if (DateTime.Now.Hour == 08)
    //        {
    //            return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
    //        }
    //        return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductsListed);
    //    }

    //    public IDataResult<List<Product>> GetAllByCategoryId(int id)
    //    {
    //        return new SuccessDataResult<List<Product>>(_productDal.GetAll(p=>p.CategoryId==id));
    //        }
    //    [CacheAspect]
    //    [PerformanceAspect(5)]
    //    public IDataResult<Product> GetById(int productID)
    //    {
    //        return new SuccessDataResult<Product>(_productDal.Get(p=>p.ProductId==productID));
    //    }

    //    public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
    //    {
    //        return new SuccessDataResult<List<Product>>(_productDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max));
    //    }
    //    public IDataResult<List<ProductDetailDto>> GetProductDetails()
    //    {
    //        return new SuccessDataResult<List<ProductDetailDto>>( _productDal.GetProductDetails());
    //    }
    //    [CacheRemoveAspect("IProductService.Get")]
    //    [ValidationAspect(typeof(ProductValidator))]
    //    public IResult Update(Product product)
    //    {
    //        throw new NotImplementedException();
    //    }
    
    //private IResult CheckIfProductCountOfCategoryCorrect(int categoryId)
    //{
    //    var result = _productDal.GetAll(p => p.CategoryId == categoryId).Count;
    //    if (result >= 100)
    //    {
    //        return new ErrorResult(Messages.ProductCategoryCountError);
    //    }
    //    return new SuccessResult();
    //}
    //private IResult CheckIfProductNameExists(string productName)
    //    {
    //        var result = _productDal.GetAll(p => p.ProductName==productName).Any();
    //        if (result)
    //        {
    //            return new ErrorResult(Messages.ProductNameExists);
    //        }
    //        return new SuccessResult();
    //    }
    //private IResult CheckIfCategoryLimitExceeded()
    //    {
    //        var result = _categpryService.GetAll();
    //        if (result.Data.Count>25)
    //        {
    //            return new ErrorResult(Messages.CategoryLimitNotAvailable);
    //        }
    //        return new SuccessResult();
    //    }
    //    [TransactionScopeAspect]
    //    public IResult AddTransactionalTest(Product product)
    //    {
    //        throw new NotImplementedException();
    //    }
    }
}
