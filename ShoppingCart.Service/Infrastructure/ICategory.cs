﻿using ShoppingCart.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Service.Infrastructure
{
    public interface ICategory
    {
        List<Category> GetAllCategories();
        Category GetCategoryByID(int Id);
        void InsertCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
        void Save();

    }
}
