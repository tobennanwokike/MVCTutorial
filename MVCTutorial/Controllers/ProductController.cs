﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorial.Abstract;
using MVCTutorial.Models;

namespace MVCTutorial.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repository;
        public int PageSize = 1;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(string category, int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = repository.Products
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ? 
                    repository.Products.Count() : 
                    repository.Products.Where( p => p.Category == category).Count()
                },
                CurrentCategory = category
            };
            return View(model);
        }
    }
}