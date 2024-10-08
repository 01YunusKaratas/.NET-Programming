using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Bu derste For ve While döngülerini tekrar edicez

            #region FOR
            // 0 dan girilen sayıya kadar olan tek sayıları yazdıralım

            /*Console.WriteLine("Lütfen bir tane sayı giriniz :");
            int answer =Convert.ToInt32(Console.ReadLine());

            int total = 0;
            List<int> list = new List<int>(); //array boyutunu bilmediğim için bunu kullandım

            for(int i = 0; i < answer; i++)
            {
                if(i %2 == 1)
                {
                    //Console.WriteLine($"{i} tek sayıdır");
                    list.Add(i); //linked liste ekledim
                    total += i;
                }
            }

            foreach(int a in list)
            {
                Console.WriteLine(a); //arraydeki sayıları tek tek döndür.
            }

            Console.WriteLine($"Tek Sayıların Toplamı : {total}");




            Console.WriteLine("break and continue");

            //break and continue
            for(int i = 1; i<10; i++){
                if( i == 3)
                {
                    continue;  // 3 e gelince 3ü atlıcak 
                   
                }

                if(i == 7)
                {
                    break; // 7 ye gelince de  sistemi sonlandırıcak
                }

                Console.WriteLine(i);
            }
            */

            #endregion

            #region WHILE

            //While Loop
            /* Console.WriteLine("Lütfen  sayı giriniz :");
             int number = int.Parse(Console.ReadLine());

             int total = 0;

             int sayaç = 1;

             while (sayaç<= number) 
             {
                 total += sayaç; // Sayaç değerini toplamaya ekle
                 sayaç++; // Sayaç artır


             }


             double avg = (double)total / number; // Ortalama hesapla (double ile bölme)

             Console.WriteLine($"Toplam: {total}"); // Toplamı yazdır
             Console.WriteLine($"Ortalama: {avg}"); // Ortalamayı yazdır*/

            #endregion


            #region FOREACH
            //ForEach 

            /*Console.WriteLine();
            Console.WriteLine("-----FOR EACH METHOD-----");
            int[] arry = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16};

            foreach (int i in arry)
            {
                Console.WriteLine($"{i}");
            }*/

            #endregion
        }
    }
}
