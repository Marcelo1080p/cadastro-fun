using cadastro_fun.Models;

int fimPrograma = 0;

while (fimPrograma == 0)
{
    Console.Write("Opções disponiveis abaixo\n[1] Ver funcioários\n[2] Cadastrar funcionário\n[3] Sair do programa\nInforme a opção desejada: ");
    string entrada = Console.ReadLine();
    if (entrada == "1")
    {
        CadastrarFunc.VerFuncionario();
    }
    else if (entrada == "2")
    {
        Console.Write("Informe o nome do colaborador: ");
        string nome = Console.ReadLine();
        Console.Write("Informe a idade do colaborador: ");
        string idadeString = Console.ReadLine();
        int idade = Convert.ToInt32(idadeString);
        CadastrarFunc.AddFuncionario(nome, idade);
    }
    else if (entrada == "3")
    {
        Console.Write("Obrigado por utilizar nosso programa!");
        fimPrograma = 1;
    }
}