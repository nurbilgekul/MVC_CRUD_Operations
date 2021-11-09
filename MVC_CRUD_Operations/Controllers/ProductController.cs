using MVC_CRUD_Operations.Models.DataTransferObject;
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
        public ActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProduct(CreateProductDTO model)
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

    }
}