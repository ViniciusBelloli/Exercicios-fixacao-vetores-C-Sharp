using System;

namespace Exercicio3
{
   class Exercicio3
   {
      static void Main(string[] args)
      {
         string[] numeros = Console.ReadLine().Split(' ');
         int n1 = int.Parse(numeros[0]);
         int n2 = int.Parse(numeros[1]);
         int[,] mat = new int[n1, n2];

         for (int i = 0; i < n1; i++)
         {
            string[] values = Console.ReadLine().Split(' ');
            for (int j = 0; j < n2; j++)
            {
               mat[i, j] = int.Parse(values[j]);
            }
         }

         int n = int.Parse(Console.ReadLine());

         for (int i = 0; i < n1; i++)
         {
            for (int j = 0; j < n2; j++)
            {
               if (mat[i, j] == n)
               {
                  Console.WriteLine($"Position {i},{j}:");
                  if (j > 0)
                  {
                     Console.WriteLine("Left: " + mat[i, j - 1]);
                  }

                  if (i > 0)
                  {
                     Console.WriteLine("Up: " + mat[i - 1, j]);
                  }

                  if (j < n2 - 1)
                  {
                     Console.WriteLine("Right: " + mat[i, j + 1]);
                  }

                  if (i < n1 - 1)
                  {
                     Console.WriteLine("Down: " + mat[i + 1, j]);
                  }
               }
            }
         }
      }
   }
}