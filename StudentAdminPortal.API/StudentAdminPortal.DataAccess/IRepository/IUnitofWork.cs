using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdminPortal.DataAccess.IRepository
{
    public interface IUnitofWork
    {
       IStudentRepository StudentRepository { get; }


        void Save();
    }
}
