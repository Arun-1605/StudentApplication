using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdminPortal.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }

        public DbSet<Student> Student { get; set; }

        public DbSet<Gender> Gender { get; set; }

        public DbSet<Address> Address { get; set; }
    }
}
