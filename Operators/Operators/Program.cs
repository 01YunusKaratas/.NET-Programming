using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region code1
            /*int a = 2;
            int b = a++;  //burada önce atama yapılır daha sonra a arttırılır.
            Console.WriteLine("B:" + b);
            Console.WriteLine("A:" + a);


            int c = 2;
            int d = ++c; //burada ise önce arttırma yapılır ardından atama operatörü kullanılır.


            Console.WriteLine("C:" + c);
            Console.WriteLine("D:" + d); */

            #endregion


            #region code2

            //int a = 10;
            //int b = 4;


            //int result = a + b;  ///arttırma operatörü
            //int result = a * b; //çarpma operatörü 
            //float result = (a / b);  //bölme operatörü
            //float result = (a % b); //mod alma operatörü kalanı söyler 
            //Console.WriteLine(result);

            //int c = a++;

            //Console.WriteLine(c);
            //Console.WriteLine(a); 
            #endregion





            #region APP

            //application for arithmetic operators
            //1 -> a =10 ,b=5,c=20  ise c-a farkının b kaçtır ? =>50
            //2 -> int? a =50; int b = 20; ise a+b  değerlerini hesaplayınız .(Eğer a null ise sonuç nedr?
            //3 -> a = 10 ; b = 20; ise a = b--; atamasının sonra a ve b değerleri kaçtır ?
            //4 -> klavyeden girilen sayının tek mi çiftmi olduğunu kontrol et.

            /*
             * SORU1 
             * int a = 10;
            int b = 5;
            int c = 20;

            int result = (c - a) * b;
            Console.WriteLine(result);*/

            /*
             * SORU2
             * int? a = 50;
             int b = 20;
             int c =(int)( a) + b;

             Console.WriteLine(c);*/



            /*
             *SORU3 
             *int a = 10;
            int b= 20;

            a = b--;
            Console.WriteLine("A :" +a);
            Console.WriteLine("B :"+b);*/

            /*
             * SORU4
             * Console.Write("Lütfen bir tane sayı giriniz:");
            int answer = int.Parse(Console.ReadLine());

            if (answer % 2 == 0)
            {
                Console.WriteLine("girilen sayı çifttir.");

            }
            else
            {

                Console.WriteLine("Girilen sayı tektir.");
            }*/

            #endregion


            #region assignment operators
            // = ,+= ,/= ,-= ,*=,%= ATAMA OPERATÖRLERİ

            //int a = 5; int b = 5; int c = 7; int d = 10; int e = 11;

            //Boolean sonuc = (a == b);
            //Console.WriteLine(sonuc);


            /*Boolean sonuc = (a != b);
            Console.WriteLine(sonuc);*/

            //Boolean sonuc = (a >= b);
            //Console.WriteLine(sonuc);

            //Boolean sonuc = (a <= b);
            //Console.WriteLine(sonuc);

            //int sonuc = (d %= a);
            //Console.WriteLine(sonuc);


            #endregion


            //COMPARISON OPERATORS

            //1 -> Klavyeden girilen yaş bilgisine göre oy kullanabilme durmunu inceleyiniz
            //2 -> Girilen bir sayının işaretini kontrol ediniz



            #region soru1
            //SORU 1

            /*while (true)
            {
                Console.WriteLine("Lütfen yaşınızı giriniz:");

                try
                {
                    int age = int.Parse(Console.ReadLine());

                    if (age > 18)
                    {
                        Console.WriteLine("Ehliyet sınavına girebilirsiniz :)");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Ehliyet sınavına giremezsiniz!!!");
                        break;
                    }
                    

                    
                }
                catch (Exception e) 
                {
                    Console.WriteLine("Lütfen yaş bilginizi giriniz !!!");

                    Console.WriteLine(" ");
                    
                }*/

            #endregion



            #region soru2
            //Soru2
            /*while (true)
                {
                    Console.WriteLine("Lütfen bir sayı giriniz:");

                    try
                    {
                        int number = int.Parse(Console.ReadLine());

                        if (number > 0)
                        {
                            Console.WriteLine($"{number}  is a positive .");
                          

                        }
                        else
                        {
                            Console.WriteLine($"{number}  is a negative .");
                            
                        }



                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Lütfen istenen formatta sayı giriniz !!!");

                        Console.WriteLine(" ");

                    }*/
            #endregion



            //APP
            //1-> Ders notu 50 ile 100 arasındaysa geçti değilse kaldın bilgisini yazdırınız.
            /*Console.WriteLine("Lütfen ders notunuzu giriniz :");
            int note = int.Parse(Console.ReadLine());

            if (note >= 50 && note <= 100)
            {
                Console.WriteLine("Dersi geçtiniz,Tebrikler");
            }
            else
            {
                Console.WriteLine("Dersten Kaldınız!");
            }*/


            //2-> Soru2
            string parola= "12345678";
            string kullanıcı_adı = "yunus emre";
            int count = 3;
           while (true)
            {
                Console.WriteLine("Lütfen kullanıcı adınızı giriniz :");
                string username = Console.ReadLine();

                Console.WriteLine("Lütfen parolayı giriniz :");
                string password = Console.ReadLine();

                if (password == parola && kullanıcı_adı == username)
                {
                    Console.WriteLine("Giriş Başarılı...");
                    break;

                }
                else
                {
                    count--;
                    Console.WriteLine("Tekrar deneyiniz");
                    if (count ==0)
                    {
                        Console.WriteLine("3 defa üst üste hatalı giriş yaptınız !! ");
                        break;
                    }
                }

            }





        }
    }
}
