using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
//Aqui eu estou definindo a estrutura principal que e a calculadora
class Calculadora

{
    static void Main()
    //Aqui eu chamo o método que inicia a execução do programa 

    {

        int opcao;
        

        do
            
        {      


            //Aqui é as mensagens que vai aparecer para o usuario
            Console.WriteLine("======== BEM-VINDO A CALCULADORA =========");
            Console.WriteLine("\n");
            Console.WriteLine("Qual operação você deseja fazer ?");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");
            Console.WriteLine("5- Potenciação");
            Console.WriteLine("0- Sair da Calculadora");
            Console.WriteLine("\n");
            Console.WriteLine("=============================================");

            // Aqui vai ser a operação que o usuario irá escolher

             opcao = int.Parse(Console.ReadLine());

            //Agora se o usuario escolher sair da calculadora 
           
            if (opcao  == 0 ) 
            {
                Console.WriteLine("................................................\n");
                Console.WriteLine("EXECUÇÃO DA CALCULADORA ENCERRADA PELO USUARIO \n");
                Console.WriteLine("................................................\n");
                break;

            }

            if (opcao >5 )
            {
                Console.WriteLine(".............................\n");
                Console.WriteLine ("POR GENTILEZA DIGITE UMA OPÇÃO VALIDA!!!!\n");
                Console.WriteLine(".............................\n");
                continue;
            }



            //Agora vamos colocar mensagens para o usuario colocar o primeiro numero, depois junto com a opção para o mesmo colocar o numero que ele gostaria de fazer a operação
            try
            {
                Console.WriteLine("Digite o primeiro número");
                double numero1 = double.Parse(Console.ReadLine());


                Console.WriteLine("Digite o segundo número");
                double numero2 = double.Parse(Console.ReadLine());

                double resultado = 0;
                //Aqui vamos colocar a mensagem de erro, quando o usuario tentar colocar 0 para divisão
                if (opcao == 4 || numero2 == 0)
                {
                    Console.WriteLine(".............................\n");
                    Console.WriteLine("ERROOO!!!!\n");
                    Console.WriteLine("DIVISÃO POR ZERO NÃO E PERMITIDA!!!!!!\n");
                    Console.WriteLine("\n");
                    Console.WriteLine(".............................\n");
                    continue;
                }
                string operacao = "";
                //coloquei string operacao e abaixo o nome, para no final a mensagem aparecer qual foi o operador lógico escolhido
                switch (opcao)
                {

                    //esses são os casos aplicados, perceba a operação bem ali
                    case 1:
                        resultado = numero1 + numero2;
                        operacao = ("Soma");
                        break;


                    case 2:
                        resultado = numero1 - numero2;
                        operacao = ("Subtração");
                        break;

                    case 3:
                        resultado = numero1 * numero2;
                        operacao = ("Multiplicação");
                        break;

                    case 4:

                        resultado = numero1 / numero2;
                        operacao = ("Divisão");
                        break;

                    case 5:
                        resultado = Math.Pow(numero1, numero2);
                        operacao = ("Pontenciação");
                        break;


                }

                //o consoleClear é pra limpar, no visor vai ficar limpinho para o usuario não ter toda aquela poluição visual
                Console.Clear();
                Console.WriteLine(".........................................\n");
                Console.WriteLine($" A {operacao} dos números {numero1}, {numero2}  é: {resultado}\n");
                Console.WriteLine(".........................................\n");
            }
            

               catch
               {
                Console.WriteLine("ERROOO");
                return;

               }
        }
        while (true);




    }

}