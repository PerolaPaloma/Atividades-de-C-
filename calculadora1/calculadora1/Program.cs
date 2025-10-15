Console.WriteLine("Qual operação você deseja fazer?");
Console.WriteLine(" 1 - Adição");
Console.WriteLine(" 2 - Substração:");
Console.WriteLine(" 3 - Multiplicação:");
Console.WriteLine(" 4 - Divisão:");

int operacao = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o primeiro numero:");
int nume1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero:");
int nume2 = int.Parse(Console.ReadLine());

int resul = 0;

string oper = "";

switch (operacao)
    {

        case 1:
             {
                resul = (nume1 + nume2);
                oper = "adição "; break;
             }


        case 2:
              {
                resul = (nume1 - nume2);
                oper = "subtração "; break;
              }


        case 3:
             {
                resul = (nume1 * nume2);
                oper = "multiplicação "; break;
             }


         case 4:
              {
                resul = (nume1 / nume2);
                oper = "divisão "; break;
              }

         default:
              Console.WriteLine("Numero não reconhecido");
              break;
         }

Console.WriteLine($"O resultado da {oper} entre {nume1} e {nume2} é: {resul}");

Console.ReadLine();
