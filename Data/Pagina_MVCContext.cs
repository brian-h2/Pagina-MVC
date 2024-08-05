using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pagina_MVC.Models;

namespace Pagina_MVC.Data
{
    public class Pagina_MVCContext : DbContext
    {
        public Pagina_MVCContext (DbContextOptions<Pagina_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<Pagina_MVC.Models.Movie> Movie { get; set; } = default!;
    }
}
