using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulationAndproperrty
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Encapsulation and Property 

            Console.WriteLine("Enter the  knowledge :");
            student s1 = new student()
            {
               
                Name = Console.ReadLine(),
                Surname = Console.ReadLine(),
                Age = int.Parse(Console.ReadLine()),
                Id= int.Parse(Console.ReadLine()),
                Section = int.Parse(Console.ReadLine()),
            };  //Create Instance for Student



            s1.show();

            


        }

    }


    class student
    {
        //Variable
        private string name;
        private string surname;
        private int age;
        private int id;
        private int section;


        //Setter and getter gibi
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
        public int Id { get => id; set => id = value; }
        public int Section { get => section; set => section = value; }


        //Constructor

        public student(string name , string surname, int age, int id , int section)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.id = id;
            this.section = section;
        }


        //Empty Constructor
        public student() { }



        public void show()
        {
            Console.WriteLine($" NAME :{name} \n SURNAME :{surname} \n AGE: {age} \n ID {id} \n SECTION :{section}");
        } 
    }    


    

}
