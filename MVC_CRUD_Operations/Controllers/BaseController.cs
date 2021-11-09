using MVC_CRUD_Operations.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CRUD_Operations.Controllers
{
    public class BaseController : Controller
    {
        public ProjectContext db;
        public BaseController()
        {
            db = new ProjectContext();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}