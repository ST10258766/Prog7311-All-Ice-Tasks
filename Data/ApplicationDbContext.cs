using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManager.Models;

namespace TaskManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<TaskManager.Models.TaskItem> TaskItem { get; set; } = default!;

        public DbSet<TaskItem> Tasks { get; set; }
       
    }
}
