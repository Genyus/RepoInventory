﻿using APIPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.BrandService
{
    public interface IBrandService
    {

        IEnumerable<Brand> GetAllBrands();

        Brand GetBrandById(int id);

        void InserBrand(Brand brand);

        void UpdateBrand(Brand brand);

        void DeleteBrand(Brand brand);


    }
}