using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AryaSock.Models;

namespace AryaSock.Data
{
    // This class represents the database context for managing Sock entities.
    public class SockContext : DbContext
    {
        public SockContext(DbContextOptions<SockContext> options)
            : base(options)
        {
        }

        // Represents a DbSet that allows interaction with Sock entities in the database.
        public DbSet<Sock> Socks { get; set; }
    }
}
