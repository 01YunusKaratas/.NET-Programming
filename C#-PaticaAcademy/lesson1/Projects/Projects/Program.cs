using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region SORU1
            //Soru 1 

            /* Console.WriteLine("Fibonacci serisinin kaç terimini görmek istiyorsunuz ? :");

             int step = int.Parse(Console.ReadLine());   


             for(int  i =1; i <= step; i++)
             {
                 Console.WriteLine(fibonacci(i) + " ");
             }




         }


         static int fibonacci(int n) //static tanımlayarak direk instance gerek olmadan yaptık işimizi
         {
             if (n <=1 )
             {
                 return n;
             }
             else
             {
                return  fibonacci(n - 1) + fibonacci(n - 2);
             }*/
            #endregion

            #region SORU2
            /* Console.WriteLine("Üçgenin boyutunu giriniz :");

               int dimension = int.Parse(Console.ReadLine()); //add info


               if (dimension < 0)
               {
                   throw new Exception("Please enter the valid dimension");
               }

               if(dimension >= 1)
               {
                   for (int i = 1; i <= dimension; i++)
                   {
                       // Boşlukları yazdır
                       for (int j = dimension; j > i; j--)
                       {
                           Console.Write(" ");
                       }
                       // * karakterlerini yazdır
                       for (int k = 1; k <= (2 * i - 1); k++)
                       {
                           Console.Write("*");
                       }
                       // Yeni satıra geç
                       Console.WriteLine();
                   }
               }*/
            #endregion

            #region SORU3
            /*Console.WriteLine("Please enter the radius :");
              int radius = int.Parse(Console.ReadLine());

              for (int y = radius; y >= -radius; y--)
              {
                  for (int x = -radius; x <= radius; x++)
                  {
                      // Daire denklemi: x^2 + y^2 <= r^2
                      if (x * x + y * y <= radius * radius)
                      {
                          Console.Write("*");
                      }
                      else
                      {
                          Console.Write(" ");
                      }
                  }
                  Console.WriteLine();
              }*/
            #endregion


            Console.WriteLine("Please enter the text :");

            string text = Console.ReadLine();

            char[] chars = text.ToCharArray(); //stringi tek tek bölcez
            char[] newChars = new char[chars.Length - 1];

            Console.WriteLine("Please enter the number :");

            int number = int.Parse(Console.ReadLine());

            for(int i = 0 ,  j = 0 ; i<chars.Length; i++)
            {
                if(i != number)
                {
                    newChars[j] = chars[i]; //add in the new array 
                    j++;
                }
            }

            string newText =new string(newChars);

            Console.WriteLine("Updated text: " + newText);






        }
    }

}
