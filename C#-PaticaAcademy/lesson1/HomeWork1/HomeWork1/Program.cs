using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console App

            #region EX1

            /* Console.WriteLine("Please enter the number :");
             int number = int.Parse(Console.ReadLine());
             List<int> list1 = new List<int>();

             Console.WriteLine();    
             Console.WriteLine($"Please enter the {number} number :");

             int count = 0;
             for (int i = 0;i<number;i++)
             {
                 int sayı = int.Parse(Console.ReadLine());

                 // Sayının çift olup olmadığını kontrol et
                 if (sayı % 2 == 0)
                 {
                     count++;    
                     list1.Add(sayı); // Çift sayıyı listeye ekle
                 }
             }


             //Write 
             foreach(int a in list1)
             {
                 Console.WriteLine("EVEN NUMBER  : " + a);



             }

             Console.WriteLine("Total Even Number :" + list1.Count());*/
            #endregion



            #region EX2

            /*Console.WriteLine("Please enter the n :");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the m :");
                int m = Convert.ToInt32(Console.ReadLine());

                //create a list

                List<int> list = new List<int>();   

                Console.WriteLine("Now," +n +" piece number :");
                for(int a = 0; a < n; a++)
                {
                    int b = Convert.ToInt32(Console.ReadLine()); //sayıları girdik
                    if(b == m)
                    {
                        list.Add(b);
                        Console.WriteLine($"{b} added in the list ");
                    }
                }
                //M controll for divide number
                for(int i = 1; i <m; i++)
                {
                    if( m%i == 0)
                    {
                        list.Add(i);
                        Console.WriteLine($"{i} added in the list ");
                    }
                }


                list.Sort();
                //write
                foreach(int i in list)
                {
                    Console.Write(i +" ");
                }*/
            #endregion



            #region EX3
            /* Console.WriteLine("Please enter the n :");

               int n = int.Parse(Console.ReadLine());

               List<string> list = new List<string>(); //create list

               Console.WriteLine($"Please enter the {n} word");
               for(int i = 0; i < n; i++)
               {
                   string word = Console.ReadLine();
                   list.Add(word);

               }

               list.Reverse();


               Console.WriteLine("-----LIST-----");
               foreach(string words in list)
               {
                   Console.WriteLine(words);
               }*/
            #endregion



            Console.WriteLine("Please enter the sentence:");

            string stnc = Console.ReadLine();

            string [] arry  = stnc.Split(' '); //divide according to space

            int count = arry.Length;

            Console.WriteLine("**************** SENTENCE INFO ****************");

            Console.WriteLine("Sentence length :" + stnc.Length );
            Console.WriteLine("Sentence Word :" + count);

        }
    }
}
