using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using module_10.University.Api.ViewModels;
using module_10.University.Domain.Students;

namespace module_10.University.Api.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentController : Controller
    {
        private readonly IStudentFacade _studentFacade;
        private readonly IMapper _mapper;

        public StudentController(IStudentFacade studentFacade, IMapper mapper)
        {
            _studentFacade = studentFacade;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public StudentModel Get([FromRoute] int id)
        {
            var student = _studentFacade.Get(id);
            var model = _mapper.Map<StudentModel>(student);
            return model;
        }
        
        [HttpPost]
        public IActionResult Create([FromBody] StudentModel model)
        {
            var student = _mapper.Map<Student>(model);
            _studentFacade.Create(student);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] StudentModel model)
        {
            var student = _mapper.Map<Student>(model);
            student.Id = id;
            _studentFacade.Update(student);
            return Ok();
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _studentFacade.Delete(id);
            return Ok();
        }
    }
}