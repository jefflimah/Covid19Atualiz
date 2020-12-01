using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19Atualiz.Models
{
    public class Login
    {
        internal string usuario;

        public class Login
        {
            public int id { get; set; }
            public string usuario { get; set; }
            public string senha { get; set; }
            public string grupo { get; set; }
        }
    }
}
