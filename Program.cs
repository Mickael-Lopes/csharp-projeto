// App de música
string boasVindas = "Bem vindo ao Screen Sound !!!";
string info = "\nO intuito desse projeto é aprender a linguagem C# através da criação de um app de música.\n";
List<string> listaBandas = new List<string>{"Beatles", "AC-DC", "Calypso"};

void exibirLogo()
{
    Console.WriteLine("🅂 🄲 🅁 🄴 🄴 🄽   🅂 🄾 🅄 🄽 🄳");
    Console.WriteLine(boasVindas);
    Console.WriteLine(info);
}

exibirLogo();
exibirMenu();

void exibirMenu()
{
    exibirLogo();
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de avaliações de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.WriteLine("\nDigite uma opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNum)
    {

        case 1: registrarBanda();
            break;
        case 2: mostrarBandas();
            break;
        case 3:
            Console.WriteLine("Você escolhei a opção " + opcaoEscolhida);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case -1:
            Console.WriteLine("Você escolheu a opção de saída " + opcaoEscolhida);
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

void registrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    listaBandas.Add(nomeBanda);
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    exibirMenu();
}

void mostrarBandas()
{
    Console.Clear();
    Console.WriteLine("Lista das bandas registradas: \n");
    for (int i = 0; i < listaBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaBandas[i]}");
    }

    Console.WriteLine("\nPressione ENTER para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    exibirMenu();
}




