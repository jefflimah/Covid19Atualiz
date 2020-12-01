using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Services
{
    public class PacienteService : IPacienteService
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteService(
            IPacienteRepository pacienteRepository
        )
        {
            _pacienteRepository = pacienteRepository;
        }

        public void Create(Paciente ent)
        {
            _pacienteRepository.Create(ent);
        }

        public void Delete(int id)
        {
            _pacienteRepository.Delete(id);
        }

        public IEnumerable<Paciente> GetAll()
        {
            return _pacienteRepository.GetAll();
        }

        public Paciente GetOne(int id)
        {
            return _pacienteRepository.GetOne(id);
        }

        public Paciente Update(Paciente ent)
        {
            return _pacienteRepository.Update(ent);
        }
    }
}
