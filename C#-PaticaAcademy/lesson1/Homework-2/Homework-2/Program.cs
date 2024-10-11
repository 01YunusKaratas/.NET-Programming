using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region QUESTION1
            /*Console.WriteLine("Please enter 20 numbers:");

                ArrayList asal = new ArrayList();
                ArrayList asalOlmayan = new ArrayList();

                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("Enter the number: ");
                    int number = int.Parse(Console.ReadLine());

                    if (number < 0)
                    {
                        throw new Exception("Please enter a positive number!!!!");
                    }
                    else
                    {
                        if (number <= 1) // 1 ve daha küçük sayılar asal değildir
                        {
                            asalOlmayan.Add(number); // Asal olmayanlar listesine ekle
                        }
                        else
                        {
                            bool isPrime = true; // Başlangıçta asal olarak varsayıyoruz
                            for (int a = 2; a <= Math.Sqrt(number); a++) // 2'den kareköküne kadar kontrol
                            {
                                if (number % a == 0) // Eğer tam bölünüyorsa
                                {
                                    isPrime = false; // Asal değil
                                    break; // Kontrolden çık
                                }
                            }

                            if (isPrime)
                            {
                                asal.Add(number); // Asal ise asal listesine ekle
                            }
                            else
                            {
                                asalOlmayan.Add(number); // Asal değilse asal olmayanlar listesine ekle
                            }
                        }
                    }
                }

                // Sonuçları yazdırma
                Console.WriteLine("*************** PRIME NUMBERS ***************");
                foreach (var i in asal)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("*************** NON-PRIME NUMBERS ***************");
                foreach (var a in asalOlmayan)
                {
                    Console.WriteLine(a);
                }*/
            #endregion


            //create 2 arraylist
            #region QUESTION2
            /* ArrayList minArray = new ArrayList();
            ArrayList maxArray= new ArrayList();

            ArrayList sayılar = new ArrayList();
            Console.WriteLine("Please enter the 20 number :");

            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"Enter the number {i} :");
                int number = int.Parse(Console.ReadLine()); // user add number .

                sayılar.Add(number);


                
            }
            //Write a all number 
            foreach(var i in sayılar)
            {
                Console.WriteLine(i);
            }


            sayılar.Sort(); //small -> big 

            for (int i = 0; i < sayılar.Count; i++)
            {
                if(i ==0  || i == 1 ||i  == 2)
                {
                    minArray.Add(sayılar[i]);
                    Console.WriteLine($"{sayılar[i]} added in the minlist");
                }
                else
                {

                }
            }

            int a = sayılar.Count - 1;
            for (int i =a; i >= 0; i--)
            {
                if(i == a || i == (a-1) ||i == (a - 2))
                {
                    maxArray.Add(sayılar[i]);
                    Console.WriteLine($"{sayılar[i]} added in the maxlist");
                }
            }


            //Calculate Average for list
            int total = 0;
            int total1 = 0;
            foreach(var i in maxArray)
            {
                total += (int)i;

            }

            foreach (var i in minArray)
            {
                total1 += (int)i;

            }

            Console.WriteLine($"TOTAL MAX : {total} , TOTAL MIN :{total1}");
           */



            #endregion


            List<char> charlist= new List<char>();

            char[] vowelLetters = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            Console.WriteLine("Please enter the sentence :");

            string sentence = Console.ReadLine().ToLower(); //all string should to be small

            sentence = sentence.Trim();

            char[] stnc = sentence.ToCharArray(); // her birini ayırdım

            foreach(char c in stnc)
            {
                if (vowelLetters.Contains(c))
                {
                    charlist.Add(c);  //eğer  vowelLetters içeriyorsa ekle dedik
                    Console.WriteLine($"{c} is added ");
                }
            }


            //WRİTE A ALL VOWEL
            int count = 0;
            foreach(char a in charlist)
            {   
                count++;    
                Console.WriteLine(a);

            }
            Console.WriteLine("TOTAL VOWEL  :" + count);

           


        }
    }
}
