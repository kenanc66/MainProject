using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductNameInvalid = "Invalid Name <2";
        public static string RecipeAdded = "Recipe added.";
        public static string CategoryAdded = "Category Added.";
        public static string MaintenanceTime="System is on maintenance.";
        public static string ProductsListed="Products listed.";
        public static string ProductCategoryCountError="Category count overrun";
        public static string ProductNameExists="Product name exists";
        public static string CategoryLimitNotAvailable="Categories are Full";
        public static string AuthorizationDenied="Invalid Authorisation";
        public static string UserRegistered="User registered succesfully";
        public static string UserNotFound="User not found. ";
        public static string PasswordError="Password Error";
        public static string SuccessfulLogin="Successfull Login";
        public static string UserAlreadyExists="The user is already registered";
        public static string AccessTokenCreated="Token Created";
    }
}
