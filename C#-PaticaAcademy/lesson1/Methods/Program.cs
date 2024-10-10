using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Method dersi
            //Büyük kod parçalarını ileride daha kısa sürede daha sorunsuz çözme işine yarıyor

            //Methodlarda geri dönüş yoksa void yazarız
            //Geri dönüş için return yazdırırız


            //2 sayı toplayan kolay bir method yazalaım

            //Console.WriteLine(added(11, 22));

            Methodlar m1 = new Methodlar();  //istance oluşturmamız lazım 
            m1.writeConsole("yunus emre karataş");

            m1.Show(12, 34);
            
        }

        //Static olarak tanımlanan methodlar direk o sınıfa ait olduğu için direk instance oluşturmadan işlemleri yapılabilir
        public static int added(int a, int b)
        {
            return a + b;  //fonksiyon parametreleri sadece fonksiyon içinde erişilir 
        }



    }

    class Methodlar
    {


        public void writeConsole(string name)  //Default olarak private tanımlanır o yüzden public kullanmalıyız 
        {
            Console.WriteLine(name);
        }

        public int ArttırVeTopla(int value1 ,int value2)
        {
            value1++;
            value2++;
            int sonuç = value2 + value1;
            return sonuç;
        }

        public void  Show(int value1, int value2)
        {
            int değer = ArttırVeTopla(value1, value2);
            Console.WriteLine(değer); // Sonucu ekrana yazdırıyoruz
        }

    }
}
