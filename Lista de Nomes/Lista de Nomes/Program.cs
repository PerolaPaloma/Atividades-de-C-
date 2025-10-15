using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> nomes = new List<string>();
        string entrada;
        int resposta = 0;
        do
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Insira os nomes para ser cadastrados");
            Console.WriteLine("------------------------------------");

            Console.Write("Nome: ");
            entrada = Console.ReadLine().ToUpper();
            Console.Clear();    

            Console.WriteLine("Deseja continuar");
            Console.WriteLine(" 1 - Sim");
            Console.WriteLine(" 2 - Não");
            Console.WriteLine("------------------------------------");

            resposta = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------------------------");

            Console.Clear();

            if (!string.IsNullOrWhiteSpace(entrada))
                nomes.Add(entrada);
            
        }

        while (resposta == 1);
        {
            
        }
        nomes.Sort();

        Console.WriteLine("\nNomes cadastrados:");
        foreach (string nome in nomes)
        {
            Console.WriteLine("- " + nome);
        }

        Console.WriteLine($"\nTotal de nomes cadastrados: {nomes.Count}");
    }
}