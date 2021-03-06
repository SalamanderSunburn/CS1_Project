﻿using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using Data.StoreData;
using Domain.DAO;
using Domain.Entities.Products;
using Microsoft.Win32;

namespace Data.DummyData
{
    public class DummyDAOForCategory : DummyDAOExtension<Category>, ICategoryRepository
    {
        public DummyDAOForCategory()
        {
            _collection = Storage.Categories;
        }
    }
}
