using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AryaSock.Models;

namespace AryaSock.Data
{
    public class SockContext : DbContext
    {
        public SockContext(DbContextOptions<SockContext> options)
            : base(options)
        {
        }

        public DbSet<Sock> Socks { get; set; } 
    }
}
