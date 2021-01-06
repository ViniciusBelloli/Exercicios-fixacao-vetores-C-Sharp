using System;

namespace Exercicio1
{
   class Exercicio1
   {
      static void Main(string[] args)
      {
         //Vetores
         Estudante[] vect = new Estudante[10];

         Console.Write("Quantos quartos serão alugados? ");
         int n = int.Parse(Console.ReadLine());

         for (int i = 1; i <= n; i++)
         {
            Console.WriteLine($"Aluguel #{i}:");

            Console.Write("Nome: ");
            String nome = Console.ReadLine();
            Console.Write("Email: ");
            String email = Console.ReadLine();
            Console.Write("Quarto: ");
            int quarto = int.Parse(Console.ReadLine());
            vect[quarto] = new Estudante(nome, email);
         }

         Console.WriteLine("\nQuartos ocupados:");
         for (int i = 0; i < 10; i++)
         {
            if (vect[i] != null)
            {
               Console.WriteLine(i + ": " + vect[i]);
            }
         }
      }
   }
}