using _206_jehanzeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _206_jehanzeb.DataDb
{
    public class StoreDb : DbContext
    {
        public StoreDb(DbContextOptions<StoreDb> options) : base(options)
        {

        }
        public DbSet<OrderModel> orders { get; set; }
    }
}
