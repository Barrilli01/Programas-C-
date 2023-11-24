using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class Acesso
    {
        string senha = "gabriel123";

        private string name;
        public bool Login(string senha)
        {
            return this.senha == senha;
        }

    }
}
