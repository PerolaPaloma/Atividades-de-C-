using System;

class GerenciadorDeTarefas
{
    static void Main()
    {
        List<string> tarefas = new List<string>();
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("GERENCIADOR DE TAREFAS");
            Console.WriteLine("------------------------");

            Console.WriteLine($"Tarefas cadastradas: {tarefas.Count}");
            Console.WriteLine("------------------------");


            Console.WriteLine("1. Adicionar tarefa");
            Console.WriteLine("2. Listar tarefas");
            Console.WriteLine("3. Remover tarefa");
            Console.WriteLine("4. Sair");
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("------------------------");


            bool entradaValida = int.TryParse(Console.ReadLine(), out opcao);

            if (!entradaValida || opcao < 1 || opcao > 4)
            {
                Console.WriteLine("Opção inválida. Pressione Enter para continuar...");
                Console.ReadLine();
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o nome da tarefa: ");
                    string novaTarefa = Console.ReadLine().Trim();

                    if (string.IsNullOrEmpty(novaTarefa))
                    {
                        Console.WriteLine("Tarefa não pode ser vazia.");
                    }
                    else if (tarefas.Contains(novaTarefa))
                    {
                        Console.WriteLine("Tarefa já existe. Duplicidade não permitida.");
                    }
                    else
                    {
                        tarefas.Add(novaTarefa);
                        Console.WriteLine($"Tarefa '{novaTarefa}' adicionada com sucesso!");
                    }
                    break;

                case 2:
                    if (tarefas.Count == 0)
                    {
                        Console.WriteLine("Nenhuma tarefa cadastrada.");
                    }
                    else
                    {
                        Console.WriteLine("------------------------");
                        Console.WriteLine("LISTA DE TAREFAS");
                        Console.WriteLine("------------------------");

                        for (int i = 0; i < tarefas.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {tarefas[i]}");
                        }
                    }
                    break;

                case 3:
                    if (tarefas.Count == 0)
                    {
                        Console.WriteLine("Nenhuma tarefa para remover.");
                    }
                    else
                    {
                        Console.WriteLine("------------------------");
                        Console.WriteLine("REMOVER TAREFA");
                        Console.WriteLine("------------------------");

                        for (int i = 0; i < tarefas.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {tarefas[i]}");
                        }

                        Console.Write("Digite o número da tarefa que deseja remover: ");
                        bool numeroValido = int.TryParse(Console.ReadLine(), out int indice);

                        if (!numeroValido || indice < 1 || indice > tarefas.Count)
                        {
                            Console.WriteLine("Número inválido.");
                        }
                        else
                        {
                            string tarefaRemovida = tarefas[indice - 1];
                            tarefas.RemoveAt(indice - 1);
                            Console.WriteLine($"Tarefa \"{tarefaRemovida}\" removida com sucesso!");
                        }
                    }
                    break;

                case 4:
                    Console.WriteLine("Encerrando o programa. Até logo!");
                    break;
            }

            Console.WriteLine("\nPressione Enter para continuar...");
            Console.ReadLine();

        } while (opcao != 4);
    }
}
