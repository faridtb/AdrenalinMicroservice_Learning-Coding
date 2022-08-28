using DoctorService.Api.Data;
using DoctorService.Api.Dtos;
using DoctorService.Api.Entities;
using DoctorService.Api.IntegrationEvents.Events;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DoctorService.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DoctorController(AppDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody]DoctorCreateDto doctorCreateDto)
        {
            // Yoxlamalar

            Doctor newDoc = new Doctor
            {
                Name = doctorCreateDto.Name,
                Phone = doctorCreateDto.Phone,
                Profession = doctorCreateDto.Profession,
                Surname = doctorCreateDto.Surname
            };

            await _context.Doctors.AddAsync(newDoc);
            await _context.SaveChangesAsync();

            //DoctorCreatedIntegrationEvent createDocEv = new DoctorCreatedIntegrationEvent(newDoc.Id);

            return Ok(newDoc);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var doctors = await _context.Doctors.ToListAsync();
            return Ok(doctors);
        }
    }
}
