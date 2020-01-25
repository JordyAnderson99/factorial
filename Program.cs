using System;

namespace Factorial_de_un_Numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            string valor = "";

            Console.WriteLine("Digite el Numero");
            valor = Console.ReadLine();
            numero = Convert.ToInt32(valor);

                factorial(numero);

            static void factorial(int num = 0)
            {
                int total = 1;

                if (num == 0)
                {
                    Console.WriteLine("No hay Factorial");
                }
                else { 

                for (int i = 1; i <= num; i++) { 
                        total = total * i;
                }
                Console.WriteLine("El Resualtado ES: {0}", total);

                }
                
            }
        }
    }
}
