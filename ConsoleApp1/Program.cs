using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Te rog sa introduci numarul de elemente: ");
            int numarElem = Convert.ToInt32(Console.ReadLine());
            int[] vec = new int[numarElem];
            
            
            for(int i = 0; i < vec.Length; i++)
            {
                Console.Write($"Vector [{i}] = ");
                vec[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("---------------------");

            int[] frequencies = new int[vec.Length];

            for (int i = 0; i < vec.Length; i++)
            {                                              
                int cont = 0;
                for (int j = 0; j < vec.Length; j++)
                {
                    if (vec[i] == vec[j])
                    {
                        cont++;
                        frequencies[i] = cont;
                    }
                }
            }
            for (int i = 0; i < frequencies.Length; i++)
            {
                Console.Write(frequencies[i]+"  ");
            }
        }
    }
}
