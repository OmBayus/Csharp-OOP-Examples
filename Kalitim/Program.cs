using System;

namespace Kalitim
{

    class Person
    {

        public Person(string name,string surname)
        {
            this.Name = name;
            this.Surname = surname;
            Console.WriteLine("Person Oluştu");
        }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual void Intro(){
            Console.WriteLine($"Name: {this.Name} Surname: {this.Surname}");
        }

    }

    class Student: Person{
        public Student(string name,string surname,int number): base(name,surname)
        {
            Console.WriteLine("Student Oluşturuldu");
            this.Number = number;
        }

        public int Number { get; set; }

        public override void Intro(){
            Console.WriteLine($"Name: {this.Name} Surname: {this.Surname} Number: {this.Number}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Ömer","By");
            Student s = new Student("Fırat","Kara",434);

            p.Intro();
            s.Intro();
        }
    }
}
