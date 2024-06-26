﻿using OCS.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.ViewModel.Category
{
    public class CategoryViewModel:BaseViewModel
    {
       
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<ProductViewModel> ProductsViewModel { get; set; }


        //public class CategoryEditViewModel : BaseViewModel
        //{
        //    public int Id { get; set; }
        //}

        //public class CategoryListViewModel : CategoryEditViewModel
        //{
        //    public int RowNum { get; set; }
        //}

        //public class CategoryDetailViewModel : CategoryEditViewModel
        //{
        //    //ProductList eklenebilir
        //}
    }
}
