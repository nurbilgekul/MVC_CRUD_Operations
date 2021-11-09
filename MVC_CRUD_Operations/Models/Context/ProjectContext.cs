using MVC_CRUD_Operations.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_CRUD_Operations.Models.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString= @"Server=DESKTOP-L4SUHVS;Database=MVCProductDb;Integrated Security= True;";
        }
        public DbSet<Product> Products { get; set; }
    }
}