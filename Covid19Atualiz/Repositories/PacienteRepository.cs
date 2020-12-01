using Covid19Atualiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19Atualiz.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private IList<Paciente> pacientesLista;

        public PacienteRepository()
        {
            pacientesLista = new List<Paciente>();
        }

        public void Create(Paciente ent)
        {
            var validator = new PacienteValidator();
            var validRes = validator.Validate(ent);
            if (validRes.IsValid)
            {
                pacientesLista.Add(ent);
            }
            else
                throw new Exception(validRes.Errors.FirstOrDefault().ToString());
        }

        public void Delete(int id)
        {
            var ent = GetOne(id);
            pacientesLista.Remove(ent);
        }

        public IEnumerable<Paciente> GetAll()
        {
            return pacientesLista;
        }

        public Paciente GetOne(int id)
        {
            return pacientesLista.FirstOrDefault(paciente => paciente.id == id);
        }

        public Paciente Update(Paciente ent)
        {
            var salvo = GetOne(ent.id);
            pacientesLista.Remove(salvo);
            pacientesLista.Add(ent);
            return ent;
        }
    }

    internal class PacienteValidator
    {
        public PacienteValidator()
        {
        }

        internal object Validate(Paciente ent)
        {
            throw new NotImplementedException();
        }
    }

    public interface IPacienteRepository
    {
    }
}
