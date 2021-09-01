using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiEntityFramework.Models;

namespace WebApiEntityFramework.Data
{
    public class WebApiEntityFrameworkContext : DbContext
    {
        public WebApiEntityFrameworkContext (DbContextOptions<WebApiEntityFrameworkContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiEntityFramework.Models.Libro> Libro { get; set; }
    }
}
