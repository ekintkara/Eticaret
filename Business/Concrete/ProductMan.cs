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
    public class ProductMan : IProductService
    {
        IProductDal _productService;

        public ProductMan(IProductDal productService)
        {
            _productService = productService;
        }

        public int add(Product ProductId)
        {
            return _productService.add(ProductId);
        }

        public int delete(Product ProductId)
        {
            return _productService.delete(ProductId);
        }

        public List<Product> GetAll()
        {
            return _productService.GetAll();    
        }

        public List<Product> GetByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int ProductId)
        {
            return _productService.GetById(ProductId);
        }

        public int update(Product ProductId)
        {
            return _productService.update(ProductId);
        }
    }
}
