using System;
class Calculadora
{
    static void Main()
    {
        int opcao;

        do
        {
            
            Console.WriteLine("_____________________________________________");
            Console.WriteLine("Qual operação você deseja fazer?:");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multriplicação");
            Console.WriteLine("4- Divisão");
            Console.WriteLine("0- Sair");
            Console.WriteLine("_____________________________________________");
            opcao = int.Parse(Console.ReadLine());



            if (opcao == 0)
            {
                Console.WriteLine("PROGRAMA ENCERRADO!");
                return;
            }

            if (opcao < 1 || opcao > 4)
            {
                Console.WriteLine("Opção invalida!! Faça novamente:");
                continue;

            }


            Console.WriteLine("Digite o primeiro número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            double num2 = double.Parse(Console.ReadLine());

            Console.Clear();
            


            if (opcao == 4 && num2 == 0)
            {
                Console.WriteLine("ERROOO!!!!");
                Console.WriteLine("DIVISÃO POR ZERO NÃO E PERMITIDA!!!!!!");
                continue;
            }
            double resultado = 0;
            string operacao = "";

            switch (opcao)
            {

                case 1:
                    resultado = num1 + num2;
                    operacao = ("ADIÇÃO");
                    break;

                case 2:
                    resultado = num1 - num2;
                    operacao = ("SUBTRAÇÃO");

                    break;

                case 3:
                    resultado = num1 * num2;
                    operacao = ("MULTIPLICAÇÃO");

                    break;

                case 4:
                    resultado = num1 / num2;
                    operacao = ("DIVISÃO");

                    break;


            }
            Console.WriteLine("\n");
            Console.WriteLine($"O RESULTADO DA {operacao} ENTRE {num1} e {num2} É :  " + resultado);
            Console.WriteLine("\n");

        }

        while (true);



    }
}



