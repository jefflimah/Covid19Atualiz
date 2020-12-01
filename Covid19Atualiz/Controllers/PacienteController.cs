using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Covid19Atualiz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteService _pacienteService;

        public PacienteController(
            IPacienteService pacienteService
        )
        {
            _pacienteService = pacienteService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var pacientes = _pacienteService.GetAll();
            return Ok(pacientes);
            
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var paciente = _pacienteService.GetOne(id);
            return Ok(paciente);
          
        }

        [HttpPost]
        public async Task<IActionResult> Post(Paciente paciente)
        {
            _pacienteService.Create(paciente);
            return Ok("paciente cadastrado ");
        }

        [HttpPut]
        public async Task<IActionResult> Put(Paciente paciente)
        {
            _pacienteService.Update(paciente);
            return Ok("paciente foi atualizado");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            _pacienteService.Delete(id);
            return Ok("paciente foi deleteado");
        }
    }
}
