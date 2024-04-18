using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastro_fun.Models
{
    public class CadastrarFunc
    {
        static List<Funcionario> funs = new List<Funcionario>
        {

        };
        public static void AddFuncionario(string nome, int idade)
        {
            funs.Add(new Funcionario { Nome = nome, Idade = idade });
        }


        public static void VerFuncionario()
        {
            if (funs.Count == 0)
            {
                Console.Write("Ainda não há funcionário cadastrado");
            }
            else
            {
                Console.Write("Dados Funcionário\n");
                foreach (var fun in funs)
                {
                    Console.WriteLine($"Dados Funcionário\nNome: {fun.Nome}, Idade: {fun.Idade}");
                }
            }
        }

    }

}