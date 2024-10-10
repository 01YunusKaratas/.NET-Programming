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

            //Method overloading and out parameter
            
            string sayı = "999";

            int outSayı;


            bool sonuç = int.TryParse(sayı, out outSayı);

            if (sonuç)
            {
                
                Console.WriteLine("İşlem başarılı");
                Console.WriteLine(outSayı);
            }
            else
            {
                Console.WriteLine("İşlem başarısız.");
                Console.WriteLine(outSayı);

            }

            methodlar m1 = new methodlar();

            m1.topla(5, 4,out int topla);


            Console.WriteLine(topla);
            
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

    //ref: Değişkenin referansını geçirir, çağrıldığında bir değer almış olmalıdır.
//TryParse, C#'ta bir verinin belirli bir türdeki değerine dönüştürülüp dönüştürülemeyeceğini kontrol etmek için kullanılan bir yöntemdir.
//out: Değişkenin referansını geçirir, ancak çağrıldığında bir değeri olmayabilir ve metot içinde kesinlikle bir değer atanmalıdır.

//out bence :out, bir metot içerisinde bir değişkene mutlaka bir değer atandığını ve bu değerin metot dışına da gönderileceğini belirtmek için kullanılır.


class methodlar
{
    public void topla(int a ,int b ,out int topla)
    {
        topla = a + b; //mutlaka fonksiyon içerisinde değer atıyosun ve bu değeri fonksiton dışında kullanabiliyosun

    }

}


//Önemli 3 konu :METHOD OVERLOADING ,REF,OUT

}
