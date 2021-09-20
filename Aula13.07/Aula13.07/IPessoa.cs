using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13._07
{
    interface IPessoa
    {
        string Nome { get; set; }
        public int Idade { get; set; }
        string Cpf { get; set; }
    }
}
