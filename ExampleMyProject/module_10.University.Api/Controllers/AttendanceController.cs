using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using module_10.University.Api.ViewModels;
using module_10.University.Domain.Attendances;

namespace module_10.University.Api.Controllers
{
    [ApiController]
    [Route("api/attendances")]
    public class AttendanceController : Controller
    {
        private readonly IAttendanceFacade _attendanceFacade;
        private readonly IMapper _mapper;

        public AttendanceController(IAttendanceFacade attendanceFacade, IMapper mapper)
        {
            _attendanceFacade = attendanceFacade;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public AttendanceModel Get([FromRoute] int id)
        {
            var attendance = _attendanceFacade.Get(id);
            var model = _mapper.Map<AttendanceModel>(attendance);
            return model;
        }

        [HttpPost]
        public IActionResult Create([FromBody] AttendanceModel model)
        {
            var attendance = _mapper.Map<Attendance>(model);
            _attendanceFacade.Create(attendance);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] AttendanceModel model)
        {
            var attendance = _mapper.Map<Attendance>(model);
            attendance.Id = id;
            _attendanceFacade.Update(attendance);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _attendanceFacade.Delete(id);
            return Ok();
        }
    }
}