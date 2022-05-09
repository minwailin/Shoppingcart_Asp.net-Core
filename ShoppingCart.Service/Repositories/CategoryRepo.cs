using ShoppingCart.DataAccess.Model;
using ShoppingCart.Service.Data;
using ShoppingCart.Service.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Service.Repositories
{
    public class CategoryRepo : ICategory
    {
        private readonly AppDbcontext _context;
        public CategoryRepo(AppDbcontext context)
        {
            _context = context;
        }
        public void DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryByID(int Id)
        {
            return _context.Categories.Where(x => x.Id == Id).FirstOrDefault();
        }

        public void InsertCategory(Category category)
        {
            _context.Categories.Add(category);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
        }
    }
}
