using System;
using System.Globalization;

namespace Teoria2
{
   class Teoria2
   {
      static void Main(string[] args)
      {
         //Vetores
         int n = int.Parse(Console.ReadLine());
         Produto[] vect = new Produto[n];
         double sum = 0, avg;

         for (int i = 0; i < n; i++)
         {
            vect[i] = new Produto();
            vect[i].Nome  = Console.ReadLine();
            vect[i].Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            sum += vect[i].Preco;
         }

         avg = (sum / n);

         Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
      }
   }
}
