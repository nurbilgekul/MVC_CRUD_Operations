using MVC_CRUD_Operations.Models.DataTransferObject;
using MVC_CRUD_Operations.Models.Entities.Abstract;
using MVC_CRUD_Operations.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CRUD_Operations.Controllers
{
    public class ProductController : BaseController
    {
        // GET: Product

        #region Create Product
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CreateProductDTO model)
        {
            if (ModelState.IsValid)
            {
                Product product = new Product();
                product.ProductName = model.ProductName;
                product.Price = model.Price;
                product.Stock = model.Stock;
                db.Products.Add(product);
                db.SaveChanges();
                return View();
            }
            else
            {
                return View(model);
            }
        }

        #endregion

        #region List Products
        [HttpGet]
        public  ActionResult List()
        {
            var productList = db.Products.Where(x => x.Status != Status.Passive).ToList();
            return View(productList);
        }
        #endregion

        #region Edit Product
        public ActionResult Edit (int id)
        {
            Product product = db.Products.FirstOrDefault(x => x.Id == id);
            EditProductDTO model = new EditProductDTO();
            model.Id = product.Id;
            model.ProductName = product.ProductName;
            model.Price = product.Price;
            model.Stock = product.Stock;
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(EditProductDTO model)
        {
            Product product = db.Products.FirstOrDefault(x => x.Id == model.Id);

            if (ModelState.IsValid)
            {
                product.ProductName = model.ProductName;
                product.Price = model.Price;
                product.Stock = model.Stock;
                product.UpdateDate = DateTime.Now;
                product.Status = Status.Modified;
                db.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                return View(model);
            }
        }
        #endregion

        #region Delete Product
        public ActionResult Delete(int id)
        {
            Product product = db.Products.FirstOrDefault(x => x.Id == id);
            product.Status = Status.Passive;
            product.DeleteDate = DateTime.Now;
            db.SaveChanges();
            return RedirectToAction("List");
        }
        #endregion

        #region Product Details
        public ActionResult Details(int id)
        {
            Product product = db.Products.FirstOrDefault(x => x.Id == id);
            return View(product);
        }
        #endregion


    }
}