using System;

namespace FrequenciaNumerica.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vezes = 0;

            Console.WriteLine("Informe quantas comparações irá fazer:");
            vezes = int.Parse(Console.ReadLine());

            int[] armazena_numero = new int[vezes];
            int[] contador = new int[vezes];


            for (int i = 0; i < armazena_numero.Length; i++)
            {
                Console.WriteLine("Informe o " + i + "° número:");
                armazena_numero[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i < vezes + 1; i++)
            {
                for (int j = 0; j < armazena_numero.Length; j++)
                {
                    if (armazena_numero[j] == i)
                        contador[i]++;
                }
            }

            for (int i = 0; i < vezes; i++)
                Console.WriteLine("O número " + i + " aparece " + contador[i] + " vez(es)");

            Console.ReadLine();
        }
    }
}
