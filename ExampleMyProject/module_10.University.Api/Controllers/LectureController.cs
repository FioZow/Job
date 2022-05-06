using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using module_10.University.Api.ViewModels;
using module_10.University.Domain.Lectures;

namespace module_10.University.Api.Controllers
{
    [ApiController]
    [Route("api/lectures")]
    public class LectureController : Controller
    {
        private readonly ILectureFacade _lectureFacade;
        private readonly IMapper _mapper;

        public LectureController(ILectureFacade lectureFacade, IMapper mapper)
        {
            _lectureFacade = lectureFacade;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public LectureModel Get([FromRoute] int id)
        {
            var lecture = _lectureFacade.Get(id);
            var model = _mapper.Map<LectureModel>(lecture);
            return model;
        }

        [HttpPost]
        public IActionResult Create([FromBody] LectureModel model)
        {
            var lecture = _mapper.Map<Lecture>(model);
            _lectureFacade.Create(lecture);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] LectureModel model)
        {
            var lecture = _mapper.Map<Lecture>(model);
            lecture.Id = id;
            _lectureFacade.Update(lecture);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _lectureFacade.Delete(id);
            return Ok();
        }
    }
}