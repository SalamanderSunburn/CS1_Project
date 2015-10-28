﻿using ContosoUI.Annotations;
using Data.DummyData;
using Domain.DAO;
using Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.ProductSearchForm
{
    public class ProductListPresenter : Presenter, ISearchPresenter
    {
        private readonly IProductListView view;
        private readonly IProductRepository model = new DummyDAOForProduct();
        private readonly ICategoryRepository categoryRepo = new DummyDAOForCategory();

        public List<Category> CategoriesList;

        public ProductListPresenter(IProductListView view)
        {
            this.view = view;
            CategoriesList = new List<Category>(categoryRepo.GetAll().ToList());
        }

        private string sku = string.Empty;
        public string SKU
        {
            get { return sku; }
            set
            {
                if (value != this.sku)
                {
                    this.sku = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string title = string.Empty;
        public string Title
        {
            get { return title; }
            set
            {
                if (value != this.title)
                {
                    this.title = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private Category Category;
        public int CategoryID
        {
            get { return (Category == null) ? 0 : Category.Id; }
            set
            {
                Category = CategoriesList.FirstOrDefault(x => x.Id == value);
                NotifyPropertyChanged();
            }
        }

        private BindingList<Product> productList = new BindingList<Product>();
        public BindingList<Product> Products
        {
            get { return productList; }
            set
            {
                if (value != this.productList)
                {
                    this.productList = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public void Add()
        {
            ProductForm.ProductView addProductForm = new ProductForm.ProductView();
            addProductForm.MdiParent = ContosoUI.MainForm.ActiveForm;
            addProductForm.Show();
        }

        public void Edit(int id)
        {
            ProductForm.ProductView editProductForm = new ProductForm.ProductView(id);
            editProductForm.MdiParent = ContosoUI.MainForm.ActiveForm;
            editProductForm.Show();
        }

        public void Search()
        {
            List<Product> products;
            if (SKU != null && Title != null && Category != null)
                products = model.GetBy(SKU, Title, Category).ToList();
            else
                products = model.GetAll().ToList();

            Products = new BindingList<Product>(products);
        }

        public void Clear()
        {
            SKU = "";
            Title = "";
            Category = null;
            Products.Clear();
        }
    }
}