using StudentAdminPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdminPortal.DataAccess.IRepository
{
    public interface IStudentRepository : IRepository<Student>
    {
        void update(Student obj);

    }
}
