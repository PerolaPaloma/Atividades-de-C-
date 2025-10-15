Console.WriteLine("Digite o numero inicial: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o numero final: ");
int num2 = int.Parse(Console.ReadLine());
int resposta = 0;

while (resposta < 1 || resposta > 3)
{
    Console.WriteLine("Como você deseja realizar a contagem: ");
    Console.WriteLine(" 1 - Normal. ");
    Console.WriteLine(" 2 - Somente os numeros pares. ");
    Console.WriteLine(" 3 - Somente os numeros impares. ");
    Console.WriteLine("--------------------------------------");


    resposta = int.Parse(Console.ReadLine());
    Console.WriteLine("--------------------------------------");

    switch (resposta)
    {
        case 1:

            if (num1 <= num2)
            {
                for (int i = num1; i <= num2; i++)

                    Console.WriteLine(i);
            }
            else
            {
                for (int i = num1; i >= num2; i--)

                    Console.WriteLine(i);

            }
            Console.WriteLine("FIM");

            break;

        case 2:
            if (num1 <= num2)
            {
                for (int i = num1; i <= num2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                for (int i = num1; i >= num2; i--)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }

                }
            }

            Console.WriteLine("FIM");

            break;

        case 3:
            if (num1 <= num2)
            {
                for (int i = num1; i <= num2; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                for (int i = num1; i >= num2; i--)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }

                }
            }

            Console.WriteLine("FIM");

            break;
        default:
            Console.WriteLine("ERRO. Selecione uma opcao valida.");
            Console.WriteLine("--------------------------------------");


            break;
    }
}




