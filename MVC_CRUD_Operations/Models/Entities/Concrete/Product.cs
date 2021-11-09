using MVC_CRUD_Operations.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CRUD_Operations.Models.Entities.Concrete
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }
}