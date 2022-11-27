using Business.Abstract;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryMan : ICategoryService
    {
        ICategoryDal categoryService;
        public CategoryMan(ICategoryDal categoryService)
        {
            this.categoryService = categoryService;
        }

        public int add(Category categoryId)
        {
            return categoryService.add(categoryId);
        }

        public int delete(Category categoryId)
        {
            return categoryService.delete(categoryId);
        }

        public List<Category> GetAll()
        {
            return categoryService.GetAll();
        }

        public List<Category> GetByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int categoryId)
        {
            return categoryService.GetById(categoryId);
        }

        public int update(Category categoryId)
        {
            return categoryService.update(categoryId);
        }
    }
}
