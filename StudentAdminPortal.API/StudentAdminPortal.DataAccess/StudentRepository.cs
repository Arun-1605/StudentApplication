using BulkyBook.DataAccess.Repository;
using StudentAdminPortal.DataAccess.Data;
using StudentAdminPortal.DataAccess.IRepository;
using StudentAdminPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdminPortal.DataAccess
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private readonly ApplicationDbContext db;

        public StudentRepository(ApplicationDbContext db) : base(db) 
        {
            this.db = db;
        }

        public void update(Student obj)
        {
           db.Student.Update(obj);  
           
        }
    }
}
