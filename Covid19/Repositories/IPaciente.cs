using Covid19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Repositories
{
    public class IPaciente
    {
        public Paciente buscaPorId(int id);
        public IList<Paciente> buscaTodosPacientes();
        public void novoPaciente(Paciente paciente);
    }
}
