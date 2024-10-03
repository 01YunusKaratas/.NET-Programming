using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Kod1
            Console.Write("Hello World ");
            Console.Write("MCBU");
            //Console.ReadLine();
            #endregion
            // üst tarafta write komutunu öğrendik

            #region Kod2
            String adSoyadSinif = "Volkan Altıntaş";
            char dogruYanlis = 'D';

            int sayi = 15;
            byte kucukSayi = 255;
            short ortaSayi = 32767;

            float ondalikliSayi = 15.4F;
            double ondalikSayi1 = 15.4;
            decimal ondalikSayi2 = 15.4M;

            Console.Write("Sayı : " + sayi);
            #endregion

            #region Kod3
            //+ , - , / ,* % matemtiksel
            // ==, <,>,>=,<= mantıksal op

            bool dogruYanlis1 = 5 == 5;
            Console.WriteLine(dogruYanlis1);
            int sayi1 = 15;
            if (sayi1 % 2 == 1)
                Console.WriteLine("Tek");
            else
                Console.Write("Çift");
            #endregion



            #region kod4
            try
            {
                Console.WriteLine("Yaşı giriniz...");
                int yas = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(yas);
            }
            catch (FormatException)
            {
                Console.WriteLine("Giriş Türü hatalı...");
            }
            catch (DivideByZeroException)
            {
                //buradaki mesaj görünsün...
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

            #endregion





        }
    }
}
