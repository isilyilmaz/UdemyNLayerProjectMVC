using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayerProjectMVC.Core.Models;
using UdemyNLayerProjectMVC.Core.Repositories;
using UdemyNLayerProjectMVC.Core.Services;
using UdemyNLayerProjectMVC.Core.UnitOfWorks;

namespace UdemyNLayerProjectMVC.Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
            return await _unitOfWork.Products.GetWithCategoryByIdAsync(productId);
        }
    }
}
