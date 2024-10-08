using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //TryCatch hata yönetimi dersi

            //Try=> Hataya sebebiyet verme ihtimali olan kodları yazarız
            //Catch => Eğer hata varsa bu  hatalardan dönecek messageları yazdırırız(Hata varsa çalışır)
            //Finally => Hata olsun olmasın her zaman çalışır 

            while (true)
            {
                try
                {
                    Console.WriteLine("Lütfen bir tane sayı giriniz:");
                    int a = Convert.ToInt32(Console.ReadLine());//Belki kullanıcı sayı girmicek 
                    //Sayı girerse işlem bitsin

                    Console.WriteLine($"Sayı : {a}");
                    
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    Console.WriteLine("Lütfen doğru formatta girdi giriniz!!!");
                }
                //finally
                //{
                   // Console.writeline("code is wor");
                //}
            }
        }
    }
}
