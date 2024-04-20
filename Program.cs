using cadastro_fun.Models;

int fimPrograma = 0;
int matricula = 0;

while (fimPrograma == 0)
{
    Console.WriteLine("Opções disponiveis abaixo\n[1] Ver funcioários\n[2] Cadastrar funcionário\n[3] Aumentar Salário\n[4] Sair do programa\nInforme a opção desejada: ");
    string entrada = Console.ReadLine();
    switch (entrada)
    {
        case "1":
            CadastrarFunc.VerFuncionario();
            break;

        case "2":
            matricula+= 1;
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
            Console.Write("\nInforme a matricula do colaborador que irá receber o aumento: ");
            int idMatricula = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInforme o número da porcentagem do aumento: ");
            int taxaDeAumento = Convert.ToInt32(Console.ReadLine());
            CadastrarFunc.DarAumentoSalario(idMatricula, taxaDeAumento);
            break;

        case "4":

            Console.Write("Obrigado por utilizar nosso programa!");
            fimPrograma = 1;
            break;
        default:
            Console.WriteLine("Entrada Invalida");
            break;
    }
}