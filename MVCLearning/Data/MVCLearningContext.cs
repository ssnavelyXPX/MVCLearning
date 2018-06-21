using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCLearning.Models
{
    public class MVCLearningContext : DbContext
    {
        public MVCLearningContext (DbContextOptions<MVCLearningContext> options)
            : base(options)
        {
        }

        public DbSet<MVCLearning.Models.Movie> Movie { get; set; }
    }
}
