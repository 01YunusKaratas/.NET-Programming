using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. int
            int sayi = 5;
            Console.WriteLine("int: " + sayi); // Çıktı: int: 5

            // 2. double
            double ondalikSayi = 5.75;
            Console.WriteLine("double: " + ondalikSayi); // Çıktı: double: 5.75

            // 3. string
            string mesaj = "Merhaba, Dünya!";
            Console.WriteLine("string: " + mesaj); // Çıktı: string: Merhaba, Dünya!

            // 4. bool
            bool durum = true;
            Console.WriteLine("bool: " + durum); // Çıktı: bool: True

            // 5. char
            char harf = 'A';
            Console.WriteLine("char: " + harf); // Çıktı: char: A

            // Değişken Tanımlama
            DeğiskenTanımlamaOrnegi();
        }

        static void DeğiskenTanımlamaOrnegi()
        {
            // Değişken tanımlama ve atama
            int baskaBirSayi; // Değişken tanımı
            baskaBirSayi = 10; // Değere atama
            Console.WriteLine("Başka bir int: " + baskaBirSayi); // Çıktı: Başka bir int: 10
        }
    }
}
