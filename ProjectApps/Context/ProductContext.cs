using ProjectApps.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectApps.Context
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}