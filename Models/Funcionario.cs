using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastro_fun.Models
{
    public class Funcionario
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public decimal Salario { get; set; }
    }
}