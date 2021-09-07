﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayerProjectMVC.Core.Repositories;
using UdemyNLayerProjectMVC.Core.UnitOfWorks;
using UdemyNLayerProjectMVC.Data.Repositories;

namespace UdemyNLayerProjectMVC.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;

        //product repository varsa al yoksa ?? ile null durumunu kontrol ediyor, yeni productrepository oluştur.
        public IProductRepository Products => _productRepository = _productRepository ?? new 
            ProductRepository(_context);

        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new 
            CategoryRepository(_context);

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
