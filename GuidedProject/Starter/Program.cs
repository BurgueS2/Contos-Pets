namespace Starter;

internal static class Program
{
    private const int MaxPets = 8;
    
    private static void Main()
    {
        var ourAnimals = InitializeAnimals();
        DisplayMainMenu();
        var menuSelection = GetUserSelection();
        ProcessMenuSelection(menuSelection, ourAnimals);
    }

    private static string[,] InitializeAnimals()
    {
        var ourAnimals = new string[MaxPets, 6];

        for (int i = 0; i < MaxPets; i++)
        {
            string animalSpecies;
            string animalId;
            string animalAge;
            string animalPhysicalDescription;
            string animalPersonalityDescription;
            string animalNickname;
            
            switch (i)
            {
                case 0:
                    animalSpecies = "dog";
                    animalId = "d1";
                    animalAge = "2";
                    animalPhysicalDescription = "Golden retriever feminino de cor creme de tamanho médio, pesando cerca de 65 libras. domesticado.";
                    animalPersonalityDescription = "adora ter a barriga esfregada e gosta de correr atrás do rabo. dá muitos beijos.";
                    animalNickname = "lola";
                    break;
                case 1:
                    animalSpecies = "dog";
                    animalId = "d2";
                    animalAge = "9";
                    animalPhysicalDescription = "grande golden retriever macho marrom-avermelhado pesando cerca de 85 libras. domesticado.";
                    animalPersonalityDescription = "adora que esfreguem as orelhas quando te cumprimenta na porta, ou a qualquer hora! adora se inclinar e dar abraços caninos.";
                    animalNickname = "loki";
                    break;
                case 2:
                    animalSpecies = "cat";
                    animalId = "c3";
                    animalAge = "1";
                    animalPhysicalDescription = "pequena fêmea branca pesando cerca de 8 quilos. caixa de areia treinada.";
                    animalPersonalityDescription = "friendly";
                    animalNickname = "Puss";
                    break;
                case 3:
                    animalSpecies = "cat";
                    animalId = "c4";
                    animalAge = "?";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickname = "";
                    break;
                default:
                    animalSpecies = "";
                    animalId = "";
                    animalAge = "";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickname = "";
                    break;
            }

            ourAnimals[i, 0] = $"ID #: {animalId}";
            ourAnimals[i, 1] = $"Espécies: {animalSpecies}";
            ourAnimals[i, 2] = $"Idade: {animalAge}";
            ourAnimals[i, 3] = $"Nome: {animalNickname}";
            ourAnimals[i, 4] = $"Descrição Física: {animalPhysicalDescription}";
            ourAnimals[i, 5] = $"Personalidade: {animalPersonalityDescription}";
        }
        
        return ourAnimals;
    }

    private static void DisplayMainMenu()
    {
        Console.Clear();
        Console.WriteLine("Bem-vindo ao aplicativo Contoso PetFriends. Suas opções do menu principal são:");
        Console.WriteLine(" [1] - Liste todas as informações atuais sobre animais de estimação");
        Console.WriteLine(" [2] - Adicione um novo amigo animal ao array ourAnimals");
        Console.WriteLine(" [3] - Certifique-se de que as idades e descrições físicas dos animais estejam completas");
        Console.WriteLine(" [4] - Certifique-se de que os apelidos dos animais e as descrições de personalidade estejam completos");
        Console.WriteLine(" [5] - Edite a idade de um animal");
        Console.WriteLine(" [6] - Edite a descrição da personalidade de um animal");
        Console.WriteLine(" [7] - Exiba todos os gatos com uma característica específica");
        Console.WriteLine(" [8] - Exiba todos os cães com uma característica específica");
        Console.WriteLine();
        Console.WriteLine("Digite o número da sua seleção (ou digite Exit para sair do programa)");
    }

    private static string GetUserSelection()
    {
        var readResult = Console.ReadLine();
        return readResult != null ? readResult.ToLower() : ""; // Retorna a string vazia se o usuário não digitou nada
    }

    private static void ProcessMenuSelection(string menuSelection, string[,] ourAnimals)
    {
        switch (menuSelection)
        {
            case "1":
                ListAllAnimals(ourAnimals);
                break;
            case "2":
                AddNewAnimal(ourAnimals);
                break;
            case "3":
                Console.WriteLine("Projeto Desafio - volte em breve para ver o progresso.");
                Console.WriteLine("Pressione a tecla Enter para continuar.");
                Console.ReadLine();
                break;
            case "4":
                Console.WriteLine("Projeto Desafio - volte em breve para ver o progresso.");
                Console.WriteLine("Pressione a tecla Enter para continuar.");
                Console.ReadLine();
                break;
            case "5":
                Console.WriteLine("EM CONSTRUÇÃO - volte no próximo mês para ver o progresso.");
                Console.WriteLine("Pressione a tecla Enter para continuar.");
                Console.ReadLine();
                break;
            case "6":
                Console.WriteLine("EM CONSTRUÇÃO - volte no próximo mês para ver o progresso.");
                Console.WriteLine("Pressione a tecla Enter para continuar.");
                Console.ReadLine();
                break;
            case "7":
                Console.WriteLine("EM CONSTRUÇÃO - volte no próximo mês para ver o progresso.");
                Console.WriteLine("Pressione a tecla Enter para continuar.");
                Console.ReadLine();
                break;
            case "8":
                Console.WriteLine("EM CONSTRUÇÃO - volte no próximo mês para ver o progresso.");
                Console.WriteLine("Pressione a tecla Enter para continuar.");
                Console.ReadLine();
                break;
        }
    }

    private static void ListAllAnimals(string[,] ourAnimals)
    {
        for (int i = 0; i < MaxPets; i++)
        {
            if (ourAnimals[i, 0] == "ID #: ") continue;
            
            Console.WriteLine();

            for (int x = 0; x < 6; x++)
            {
                Console.WriteLine(ourAnimals[i, x]);
            }
        }
        
        Console.WriteLine("\n\rPressione a tecla Enter para continuar");
        Console.ReadLine();
    }

    private static void AddNewAnimal(string[,] ourAnimals)
    {
        var anotherPet = "y";
        var petCount = 0;

        for (int i = 0; i < MaxPets; i++)
        {
            if (ourAnimals[i, 0] != "ID #: ")
            {
                petCount += 1;
            }
        }

        if (petCount < MaxPets)
        {
            Console.WriteLine($"Atualmente temos {petCount} animais de estimação que precisam de lares. Podemos gerenciar mais {MaxPets - petCount}.");
        }

        while (anotherPet == "y" && petCount < MaxPets)
        {
            var validEntry = false;
            var animalSpecies = "";
            var animalAge = "";
            var animalPhysicalDescription = "";
            var animalPersonalityDescription = "";
            var animalNickname = "";

            // Obter espécie (gato ou cachorro) - string animalSpecies é um campo obrigatório

            do
            {
                Console.WriteLine("\n\rDigite 'cachorro' ou 'gato' para iniciar o processo de adicionar um novo animal de estimação");
                var readResult = Console.ReadLine();

                if (readResult == null) continue;
                
                animalSpecies = readResult.ToLower();
                
                if (animalSpecies != "cachorro" && animalSpecies != "gato")
                {
                    validEntry = false;
                }
                else
                {
                    validEntry = true;
                }
                
            } while (validEntry == false);

            // Construir o número de identificação do animal - por exemplo C1, C2, D3 (para Cat 1, Cat 2, Dog 3)
            var animalId = string.Concat(animalSpecies.AsSpan(0, 1), (petCount + 1).ToString()); // Substitui o Substring

            // Obter a idade do animal. Pode ser ? na entrada inicial.
            do
            {
                Console.Write("Digite a idade do animal de estimação ou digite '?' se desconhecido: ");
                var readResult = Console.ReadLine();

                if (readResult == null) continue;
                
                animalAge = readResult;
                
                validEntry = animalAge == "?" || int.TryParse(animalAge, out _);
                
            } while (validEntry == false);

            // Obter uma descrição da aparência/condição física do animal - animalPhysicalDescription pode ser em branco.
            do
            {
                Console.Write("Insira uma descrição física do animal de estimação (tamanho, cor, sexo, peso, domesticado): ");
                var readResult = Console.ReadLine();

                if (readResult == null) continue;
                
                animalPhysicalDescription = readResult.ToLower();
                
                if (animalPhysicalDescription == "")
                {
                    animalPhysicalDescription = "tbd"; // A sigla "tbd" significa "a ser determinado"
                }
                
            } while (animalPhysicalDescription == "");

            // Obter uma descrição da personalidade do animal - animalPersonalityDescription pode ser em branco.
            do
            {
                Console.Write("Insira uma descrição da personalidade do animal de estimação (gostos ou desgostos, truques, nível de energia): ");
                var readResult = Console.ReadLine();

                if (readResult == null) continue;
                
                animalPersonalityDescription = readResult.ToLower();
                
                if (animalPersonalityDescription == "")
                {
                    animalPersonalityDescription = "tbd";
                }
                
            } while (animalPersonalityDescription == "");

            // Obter o apelido do animal. animalNickname pode ser em branco.
            do
            {
                Console.Write("Digite um apelido para o animal de estimação ou pressione Enter para continuar: ");
                var readResult = Console.ReadLine();

                if (readResult == null) continue;
                
                animalNickname = readResult.ToLower();
                
                if (animalNickname == "")
                {
                    animalNickname = "tbd";
                }
                
            } while (animalNickname == "");

            // Armazenar as informações do animal no array ourAnimals (baseado em zero)
            ourAnimals[petCount, 0] = $"ID #: {animalId}";
            ourAnimals[petCount, 1] = $"Especie: {animalSpecies}";
            ourAnimals[petCount, 2] = $"Idade: {animalAge}";
            ourAnimals[petCount, 3] = $"Nome: {animalNickname}";
            ourAnimals[petCount, 4] = $"Descrição Física: {animalPhysicalDescription}";
            ourAnimals[petCount, 5] = $"Personalidade: {animalPersonalityDescription}";

            // Incrementar petCount (o array é baseado em zero, então incrementamos o contador após adicionar ao array)
            petCount += 1;

            // Verificar o limite de maxPet
            if (petCount >= MaxPets) continue;
            {
                // outro animal?
                Console.Write("Você deseja inserir informações de outro animal de estimação (s/n): ");
                
                do
                {
                    var readResult = Console.ReadLine();
                    
                    if (readResult != null)
                    {
                        anotherPet = readResult.ToLower();
                    }
                    
                } while (anotherPet != "y" && anotherPet != "n");
            }
        }

        if (petCount < MaxPets) return;
        
        Console.WriteLine("Atingimos nosso limite de número de animais de estimação que podemos gerenciar. Obrigado por usar o aplicativo Contoso PetFriends.");
        Console.WriteLine("Pressione a tecla Enter para continuar.");
        Console.ReadLine();
    }
}