using System;
using System.Globalization;


namespace ExercicioVetores
{
   class Teoria1
   {
      static void Main(string[] args)
      {
         //Vetores
         int n = int.Parse(Console.ReadLine());
         double[] vect = new double[n];
         double sum = 0, avg;

         for (int i = 0; i < n; i++)
         {
            vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            sum += vect[i];
         }

         avg = (sum / n);

         Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));
      }
   }
}
