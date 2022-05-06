using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using module_10.University.Api.ViewModels;
using module_10.University.Domain.Lecturers;

namespace module_10.University.Api.Controllers
{
    [ApiController]
    [Route("api/lecturers")]
    public class LecturerController : Controller
    {
        private readonly ILecturerFacade _lecturerFacade;
        private readonly IMapper _mapper;

        public LecturerController(ILecturerFacade lecturerFacade, IMapper mapper)
        {
            _lecturerFacade = lecturerFacade;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public LecturerModel Get([FromRoute] int id)
        {
            var lecturer = _lecturerFacade.Get(id);
            var model = _mapper.Map<LecturerModel>(lecturer);
            return model;
        }

        [HttpPost]
        public IActionResult Create([FromBody] LecturerModel model)
        {
            var lecturer = _mapper.Map<Lecturer>(model);
            _lecturerFacade.Create(lecturer);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] LecturerModel model)
        {
            var lecturer = _mapper.Map<Lecturer>(model);
            lecturer.Id = id;
            _lecturerFacade.Update(lecturer);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _lecturerFacade.Delete(id);
            return Ok();
        }
    }
}