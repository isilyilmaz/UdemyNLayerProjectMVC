﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayerProjectMVC.Core.Models;
using UdemyNLayerProjectMVC.Core.Repositories;

namespace UdemyNLayerProjectMVC.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        //repository içindeki context i appdbcontext e dönüştürmem lazım. çünkü ne olduğunu biliyorum.
        private AppDbContext appDbContext { get => _context as AppDbContext; }
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Category> GetWithProductsByIdAsync(int categoryId)
        {
            return await appDbContext.Categories.Include(x => x.Products)
                                                .SingleOrDefaultAsync(x => x.Id == categoryId);
        }
    }
}
