using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region kod2
            /*string name = "yunus emre karataş";
               string message = $"{name} karataş";

               Console.WriteLine(message);



               Console.ReadKey();// kullanıcı bir tuşa basana kadar bekler.  */



            /* string name = "yunus emre karataş c# dersini bugun bitiricek";

             string[] result  = name.Split(' ');

             foreach (string kelime in result)
             {
                 Console.WriteLine(kelime);
             }


             Console.ReadKey();*/

            /*char a = 'a';
            string b = "yunus emre ";
            Console.WriteLine(a);
            Console.WriteLine(b);



            while (true)
            {
                Console.WriteLine("Lütfen isim ve soyisminizi giriniz:");
                string name = Console.ReadLine();
                Console.WriteLine("Lütfen okul numaranızı giriniz:");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Lütfen cinsiyetinizi giriniz :");
                string gender = Console.ReadLine();
                if (gender == "male")
                {
                    Console.WriteLine("Your gender is male");
                }
                else if (gender == "female")
                {
                    Console.WriteLine("Your gender is female");
                }
                else
                {
                    Console.WriteLine("Please try again gender info");
                }
                Console.WriteLine("Lütfen doğum yılınzıı giriniz");
                string birthday = Console.ReadLine();
                Console.WriteLine("Lütfen yaşınızı giriniz :");
                int age = int.Parse(Console.ReadLine());
                if (age < 0)
                {
                    Console.WriteLine("Lütfen doğru yaş bilgisi giriniz :");
                }
                else
                {
                    Console.WriteLine("Yaşınız :" + age);
                }



                Console.WriteLine("İSİM SOYİSİM :" + name + "\n" + "Okul Numarası :" + number + "\n" + "Gender :" + gender + "\n" + "Birthday:" + birthday + "\n" + "Age :" + age);

                   
            }*/

            #endregion


            //Örnek uygulama

            string courseName = "C# programming language with .NET 7";

            // How much it have got character ?

            Console.WriteLine(courseName.Length); //35

            //all character must be lowercase

            Console.WriteLine(courseName.ToLower()); //c# programming langua with .net 7

            //is it starting '.'  character? 

            Console.WriteLine(courseName.StartsWith(".")); //False

            //in which location is C# located?

            Console.WriteLine(courseName.IndexOf("C#")); // 0

            //'Language' with change 'Lessons'
            string updatedCourseName = courseName.Replace("language", "Lessons");

            // Güncellenmiş dizeyi yazdır
            Console.WriteLine(updatedCourseName); // "Programming Lessons" olarak yazdırır













            Console.Read();
        }
    }
}
