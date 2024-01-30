using DesafioPOO.Models;

Console.WriteLine("Cadastro de telefone");
List<Smartphone> smartphones = [];
string acao = string.Empty;
do
{
    Console.WriteLine("Informe uma ação:");
    Console.WriteLine("1) Cadastrar celular.");
    Console.WriteLine("2) Listar aparelhos.");
    Console.WriteLine("3) Sair.");
    string resp = Console.ReadLine();

    if (resp == "1")
    {
        Console.WriteLine("Informe a marca (nokia/iphone): ");
        string marca = Console.ReadLine();

        if (marca != "nokia" && marca != "iphone")
        {
            Console.WriteLine("Marca inválida...");
            continue;
        }

        Console.WriteLine("Informe o número: ");
        string numero = Console.ReadLine();
        Console.WriteLine("Informe o modelo: ");
        string modelo = Console.ReadLine();
        Console.WriteLine("Informe o IMEI: ");
        string imei = Console.ReadLine();
        Console.WriteLine("Informe a memória: ");
        int memoria = Convert.ToInt32(Console.ReadLine());

        Smartphone smartphone = marca == "nokia" ?
            new Nokia(numero, modelo, imei, memoria) :
            new Iphone(numero, modelo, imei, memoria);

        Console.WriteLine("Testando aparelho: ");
        smartphone.Ligar();
        smartphone.InstalarAplicativo("whatsapp");
        smartphones.Add(smartphone);
    }
    else if (resp == "2")
    {
        foreach (var smartphone in smartphones)
        {
            Console.WriteLine(smartphone);
        }
    }
    else if (resp == "3")
    {
        acao = "sair";
    }
    else
        Console.WriteLine("Ops! Tente de novo...");


} while (acao != "sair");
Console.WriteLine("Volte sempre!");