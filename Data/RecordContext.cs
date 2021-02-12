using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using moment3._2.Models;

namespace moment3._2.Data
{
    public class RecordContext : DbContext
    {
        public RecordContext(DbContextOptions<RecordContext> options) : base(options)
        {
        }
        // Creates a table and name it 'Record'
        public DbSet<Record> Record { get; set; }
        // Creates a table and name it 'User'
        public DbSet<User> User { get; set; }

    }
}
