using Business.Abstract;
using Business.ValidationRules;
using DataAccess.Concrete;
using Entity;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdminUI.Controllers
{
    public class ProductController : Controller
    {
        IProductService productService;
        

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
       
        public IActionResult Index()
        {
         return View();
        } 

        [HttpGet]
        [Authorize(Roles ="Admin")]
        public IActionResult List ()
        {
            var result = productService.GetAll();
            return View(result);
        }

        [HttpGet]
        public IActionResult Add() 
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            ProductValidation productvalidation = new ProductValidation();
            ValidationResult results = productvalidation.Validate(product);
            if (results.IsValid)
            {
                productService.add(product);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var result = productService.GetById(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Update(Product product)
        {
            ProductValidation productvalidation = new ProductValidation();
            ValidationResult results = productvalidation.Validate(product);
            if (results.IsValid)
            {
               productService.update(product);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var result = productService.GetById(id);
            productService.delete(result);
            return RedirectToAction("List");
        }
    }
}
