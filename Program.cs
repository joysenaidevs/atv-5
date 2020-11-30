using System;

namespace atv_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada do 1 ao 10");
           
            for (var i = 1; i <=10; i++)
            {
                Console.WriteLine(i);

                for (var z = 1; z <=10; z++)
                {
                    Console.WriteLine($"{i} x {z} = {(i*z)}"); // para mostrar variavel, colocar dentro de um calculo; para calcular, dentro de parentese.

                }
            }
           
        }
    }
}
