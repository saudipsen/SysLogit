using SysLogit.Business.Contracts;
using SysLogit.Models;
using SysLogit.Repository.Contracts.SysLogit.Repository.Contracts;
using SysLogit.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLogit.Business.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repository;

        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public Response<IEnumerable<Product>> GetAllProducts()
        {
            return _repository.GetAll();
        }

        public Response<Product> GetProductById(int id)
        {
            return _repository.GetById(id);
        }

        public Response<string> AddProduct(Product product)
        {
            return _repository.Add(product);
        }

        public Response<string> UpdateProduct(Product product)
        {
            return _repository.Update(product);
        }

        public Response<string> DeleteProduct(int id)
        {
            return _repository.Delete(id);
        }
    }

}
