using StudentAdminPortal.DataAccess.Data;
using StudentAdminPortal.DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdminPortal.DataAccess
{
    public class UnitofWork : IUnitofWork
    {
        private readonly ApplicationDbContext applicationDbContext;

        public UnitofWork(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
            StudentRepository = new StudentRepository(applicationDbContext);
        }

        public IStudentRepository StudentRepository { get; private set; }

        public void Save()
        {
            applicationDbContext.SaveChanges();
        }


    }
}
