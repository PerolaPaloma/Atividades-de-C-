using System;
class Program
{
    static void Main()

    {
        Console.WriteLine("=================================");
        Console.WriteLine("Data e Hora:" + DateTime.Now);
        Console.WriteLine("Bem-vindo à Calculadora Simples!");
        Console.WriteLine("=================================");

        string continuar = "sim";
        int certos = 0;
        int erros = 0;


        while (continuar.ToLower() == "sim")
        {
            Console.WriteLine("Qual operação você deseja fazer?");
            Console.WriteLine(" 1 - Adição (+)");
            Console.WriteLine(" 2 - Substração (-)");
            Console.WriteLine(" 3 - Multiplicação (x)");
            Console.WriteLine(" 4 - Divisão (/)");
            Console.WriteLine(" 5 - Módulo (%)");
            Console.WriteLine(" 6 - Sair");
            Console.WriteLine("=================================");

            int operacao = int.Parse(Console.ReadLine());
            Console.WriteLine("=================================");

            if (operacao == 6)
            {
                Console.WriteLine("=================================");
                Console.WriteLine($"O total de operações realizadas é {certos} :");
                Console.WriteLine($"O total de erros encontrados {erros}:");
                Console.WriteLine("Encerrando a calculadora. Até logo!");
                Console.WriteLine("=================================");
                return; // Finaliza o programa
            }


            Console.WriteLine("Digite o primeiro numero:");
            double nume1 = double.Parse(Console.ReadLine());
            Console.WriteLine("=================================");

            Console.WriteLine("Digite o segundo numero:");
            double nume2 = double.Parse(Console.ReadLine());
            Console.WriteLine("=================================");


            double resul = 0;


            string oper = "";


            switch (operacao)
            {
                case 1:
                    {
                        resul = (nume1 + nume2);
                        oper = "adição ";
                        certos++;
                        break;
                    }


                case 2:
                    {
                        resul = (nume1 - nume2);
                        oper = "subtração ";
                        certos++;
                        break;
                    }


                case 3:
                    {
                        resul = (nume1 * nume2);
                        oper = "multiplicação ";
                        certos++;
                        break;
                    }


                case 4:
                    {
                        if (nume2 == 0)
                        {
                            Console.WriteLine("Operação não permitida com divisor zero!");
                            Console.WriteLine("=================================");

                            erros++;
                            continue;

                        }
                        else
                        {
                            resul = (nume1 / nume2);
                            oper = "divisão ";
                            certos++;
                            break;
                        }
                    }

                case 5:
                    {
                        if (nume2 == 0)
                        {
                            Console.WriteLine("Operação não permitida com divisor zero!");
                            Console.WriteLine("=================================");
                            erros++;
                            continue;
                        }
                        else
                        {
                            resul = (nume1 % nume2);
                            oper = "módulo";
                            certos++;
                            break;
                        }
                    }

                default:

                    Console.WriteLine("Numero não reconhecido");
                    break;
            }

            Console.WriteLine($"O resultado da {oper} entre {nume1} e {nume2} é: {resul:F2}");
            Console.WriteLine("Deseja continuar: Sim / Nao");
            continuar = Console.ReadLine().ToLower();
            Console.Clear();
        }
        Console.Clear();
        Console.WriteLine("=================================");
        Console.WriteLine($"O total de operações realizadas é {certos} :");
        Console.WriteLine($"O total de erros encontrados {erros}:");
        Console.WriteLine("Encerrando a calculadora. Até logo!");
        Console.WriteLine("=================================");



    }
}