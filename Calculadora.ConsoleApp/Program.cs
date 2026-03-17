string[] historicoOperacoes = new string[100];
int contadorOperacoes = 0;
int resultado = 0;
string textoOperacao = " ";

while (true == true)

{ 
Console.Clear();
Console.WriteLine("--------------------------------------");
Console.WriteLine("Calculadora 2026");
Console.WriteLine("--------------------------------------");
Console.WriteLine("1 - Somar");
Console.WriteLine("2 - Subtrair");
Console.WriteLine("3 - Multiplicar");
Console.WriteLine("4 - Dividir");
Console.WriteLine("5 - Tabuada");
Console.WriteLine("6 - Historico");
Console.WriteLine("S - Sair");
Console.WriteLine("--------------------------------------");
Console.Write("Escolha uma opcao valida: ");


string opcao = Console.ReadLine();

if (opcao == "S" || opcao == "s")
{
    break;
}

if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "s" && opcao != "S" && opcao != "5" && opcao != "6")
    {
        Console.WriteLine("Opcao Invalida");
        Console.ReadLine();
        continue;
    }

if (opcao == "5")
    {
        Console.Write("Digite o número desejado: ");
        string strNumeroTabuada = Console.ReadLine();
        int numeroTabuada = Convert.ToInt32(strNumeroTabuada);

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numeroTabuada} x {i} = {numeroTabuada * i}");
        }

        Console.ReadLine();
        continue; 
    }

if (opcao == "6")
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Historico de operacoes");
        Console.WriteLine("--------------------------------------");

        for(int i = 0; i < historicoOperacoes.Length; i++)
        {
            if (historicoOperacoes[i] != null)
            {
                 Console.WriteLine(historicoOperacoes[i]); 
            }
            
        }
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Digite enter para continuar...");
        Console.ReadLine();

        continue;
    }
Console.Write("Digite o primeiro Numero: ");
string strprimeiroNumero= Console.ReadLine();

int primeiroNumero = Convert.ToInt32(strprimeiroNumero);

Console.Write("Digite o segundo numero: ");
string strsegundoNumero = Console.ReadLine();

if (opcao == "1")
{
int segundoNumero = Convert.ToInt32(strsegundoNumero);
    resultado = primeiroNumero + segundoNumero;
    textoOperacao = $"{primeiroNumero} + {segundoNumero} = {resultado}";
}

else if(opcao == "2")
{
int segundoNumero = Convert.ToInt32(strsegundoNumero);

    resultado = primeiroNumero - segundoNumero;
    textoOperacao = $"{primeiroNumero} - {segundoNumero} = {resultado}";  
}

else if(opcao == "3")
{
int segundoNumero = Convert.ToInt32(strsegundoNumero);

    resultado = primeiroNumero * segundoNumero;
    textoOperacao = $"{primeiroNumero} * {segundoNumero} = {resultado}";   
}

else
{
int segundoNumero = Convert.ToInt32(strsegundoNumero);

    if(segundoNumero == 0)
        {
            Console.WriteLine("Nao eh possivel dividir por zero");
            Console.ReadLine();
            continue;
        }

    resultado = primeiroNumero / segundoNumero;
    textoOperacao = $"{primeiroNumero} / {segundoNumero} = {resultado}";   
}

    historicoOperacoes[contadorOperacoes] = textoOperacao;

    contadorOperacoes ++;

    if (contadorOperacoes < historicoOperacoes.Length)
    {
        historicoOperacoes[contadorOperacoes] = textoOperacao;
        contadorOperacoes++;
    }

Console.WriteLine("O resultado eh: " + resultado);
Console.ReadLine();

}