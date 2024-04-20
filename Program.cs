﻿using cadastro_fun.Models;

int fimPrograma = 0;

while (fimPrograma == 0)
{
    Console.WriteLine("Opções disponiveis abaixo\n[1] Ver funcioários\n[2] Cadastrar funcionário\n[3] Sair do programa\nInforme a opção desejada: ");
    string entrada = Console.ReadLine();
    switch (entrada)
    {
        case "1":
            CadastrarFunc.VerFuncionario();
            break;

        case "2":

            int matricula = 1;
            Console.Write("Informe o nome do colaborador: ");
            string nome = Console.ReadLine();
            Console.Write("Informe a idade do colaborador: ");
            string idadeString = Console.ReadLine();
            int idade = Convert.ToInt32(idadeString);
            Console.Write("Informe o salário inicial: ");
            string salarioString = Console.ReadLine();
            decimal salario = Convert.ToDecimal(salarioString);
            CadastrarFunc.AddFuncionario(matricula, nome, idade, salario);
            break;

        case "3":

            Console.Write("Obrigado por utilizar nosso programa!");
            fimPrograma = 1;
            break;
        default:
            Console.WriteLine("Entrada Invalida");
            break;
    }
}