using Microsoft.AspNetCore.Mvc;
using BackendAPI.Models;
using BackendAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace BackendAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PatientsController(AppDbContext context)
        {
            _context = context;
        }

        // GET ALL PATIENTS
        [HttpGet]
        public async Task<IActionResult> GetPatients()
        {
            var patients =
                await _context.Patients.ToListAsync();

            return Ok(patients);
        }

        // GET PATIENT BY ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatientById(int id)
        {
            var patient =
                await _context.Patients.FindAsync(id);

            if (patient == null)
            {
                return NotFound(new
                {
                    message = "Patient not found"
                });
            }

            return Ok(patient);
        }

        // CREATE PATIENT
        [HttpPost]
        public async Task<IActionResult> AddPatient(
            Patient patient)
        {
            _context.Patients.Add(patient);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                message =
                    "Patient added successfully"
            });
        }

        // UPDATE PATIENT
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePatient(
            int id,
            Patient updatedPatient)
        {
            var patient =
                await _context.Patients.FindAsync(id);

            if (patient == null)
            {
                return NotFound(new
                {
                    message = "Patient not found"
                });
            }

            patient.Name =
                updatedPatient.Name;

            patient.Age =
                updatedPatient.Age;

            patient.Gender =
                updatedPatient.Gender;

            patient.InsuranceProvider =
                updatedPatient.InsuranceProvider;

            await _context.SaveChangesAsync();

            return Ok(new
            {
                message =
                    "Patient updated successfully"
            });
        }

        // DELETE PATIENT
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatient(
            int id)
        {
            var patient =
                await _context.Patients.FindAsync(id);

            if (patient == null)
            {
                return NotFound(new
                {
                    message = "Patient not found"
                });
            }

            _context.Patients.Remove(patient);

            await _context.SaveChangesAsync();

            return Ok(new
            {
                message =
                    "Patient deleted successfully"
            });
        }
    }
}