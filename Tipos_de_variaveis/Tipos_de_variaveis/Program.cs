using System;

namespace Tipos_de_variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipagem estática
            int i = 1;
            //Tipagem dinâmica
            var x = 2;

            //Tipagem estática
            string s = "Nome";
            //Tipagem dinâmica
            var s2 = "Nome 2";

            float f = 1.5f;
            var f2 = 1.5f;

            double d = 1.5;
            var d2 = 1.5;

            bool bo = true;
            var bo2 = true;

            char a = 'a';
            string b = "b";


            //conversão
            bool boolean = bool.Parse("false");          //parse converte string
            bool boolean2 = Convert.ToBoolean("false");  //Converte objetos para formato boolean
            d.ToString(); // conversão para string
        }
    }
}
