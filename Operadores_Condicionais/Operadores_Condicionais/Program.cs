using System;

namespace Operadores_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //if, else if, else
            var a = 1;
            if (a == 1)
            {
                Console.WriteLine("entrou na condição do if");
            }
            else if (a == 2)
            {
                Console.WriteLine("entrou na condição do else if = 2");
            }
            else
            {
                Console.WriteLine("entrou na condição do else");
            }

            //Switch
            switch (a)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }

            //Ternário
            string texto = (a == 1 ? "A vale 1" : "A tem valor diferente de 1");
            Console.WriteLine(texto);

        }
    }
}
