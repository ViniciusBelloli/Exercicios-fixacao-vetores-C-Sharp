using System;

namespace Teoria3
{
   class Teoria3
   {
      static void Main(string[] args)
      {
         //params
         int result = Calculator.Sum(10, 20, 30, 40);
         Console.WriteLine(result);

         //ref precisa inicializar variável
         int a = 10;
         Calculator.Triple(ref a);
         Console.WriteLine(a);

         //out não precisa inicializar variável
         int b = 20;
         int triple;
         Calculator.Triple(b, out triple);
         Console.WriteLine(triple);
      }
   }
}