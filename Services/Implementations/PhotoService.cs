﻿using KeplerCMS.Areas.Housekeeping.Models.Views;
using KeplerCMS.Data;
using KeplerCMS.Data.Models;
using KeplerCMS.Models;
using KeplerCMS.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeplerCMS.Services.Implementations
{
    public class PhotoService : IPhotoService
    {
        private readonly DataContext _context;

        public PhotoService(DataContext context)
        {
            _context = context;
        }

        public async Task<ItemsPhotos> Get(int id)
        {
            return await _context.ItemsPhotos.Where(s => s.Id == id).FirstOrDefaultAsync();
        }

    }

}
