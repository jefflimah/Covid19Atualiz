using Covid19Atualiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19Atualiz.Repositories
{
    public class IPaciente
    {
        public Paciente BuscaPorId(int id);
        public IList<Paciente> BuscaTodosPacientes();
        public void novoPaciente(Paciente paciente);
    }
}
