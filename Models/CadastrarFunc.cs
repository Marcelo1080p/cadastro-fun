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
        public static void AddFuncionario(int matricula,string nome, int idade, decimal salario)
        {
            funs.Add(new Funcionario { Matricula = matricula, Nome = nome, Idade = idade, Salario = salario });
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
                    Console.WriteLine("-----------------------------------------------");
                    Console.Write($"Dados Funcionário\nMatricula: {fun.Matricula}, Nome: {fun.Nome}\nIdade: {fun.Idade}, Salário: {fun.Salario}R$\n");
                    Console.WriteLine("-----------------------------------------------");
                }
            }
        }

    }

}