using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using StudentAdminPortal.DataAccess.IRepository;
using StudentAdminPortal.Models;

namespace StudentAdminPortal.API.Controllers
{
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IUnitofWork obj;
        private readonly IMapper mapper;

        public StudentController(IUnitofWork obj,IMapper mapper)
        {
            this.obj = obj;
            this.mapper = mapper;
        }


        [HttpGet]
        [Route("Controller")]
        public IActionResult GetAllStudent()
        {
            IEnumerable<Student> students = obj.StudentRepository.GetAll(includeProperties:"Address,Gender");

            return Ok(mapper.Map<List<ViewModels.Student>>(students));
            
        }
    }
}
