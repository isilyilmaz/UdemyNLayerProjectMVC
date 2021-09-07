using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayerProjectMVC.Core.Models;
using UdemyNLayerProjectMVC.Core.Repositories;
using UdemyNLayerProjectMVC.Core.Services;
using UdemyNLayerProjectMVC.Core.UnitOfWorks;

namespace UdemyNLayerProjectMVC.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Category> GetWithProductsByIdAsync(int categoryId)
        {
            return await _unitOfWork.Categories.GetWithProductsByIdAsync(categoryId);
        }
    }
}
