using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShoppingAPIs.Models
{
    public class OshoppingDBContext:DbContext
    {
        public OshoppingDBContext(DbContextOptions<OshoppingDBContext> options): base (options)
        {

        }

        public DbSet<Users> Users { get; set; }
    }
}
