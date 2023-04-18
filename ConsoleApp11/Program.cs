using System;
using System.Collections.Generic;

namespace ConsoleApp11
{
    class Student
    {
        public Student(string name, string surename, int kurs, int pay)
        {
            this.Name = name;
            this.Surename = surename;
            this.Kurs = kurs;
            this.Pay = pay;
        }
        public string Name { get; set; }
        public string Surename { get; set; }
        public int Kurs { get; set; }
        public int Pay { get; set; }
        public void Display()
        {
            Console.WriteLine($"Имя:{Name} Фамилия: {Surename} Курс: {Kurs} Стипендия: {Pay}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();
            int b;
            int count = 1;
            int kurs;
            string name;
            string surename;
            int pay;
            int max = 0;
            int twomax = 0;
            int threemax = 0;
            int fourmax = 0;
            int fivemax = 0;
            
            Console.WriteLine("Введите чиcло студентов: ");
            b = Convert.ToInt32(Console.ReadLine());
            while (b > 100)
            {
                Console.WriteLine("Введите чиcло студентов: ");
                b = Convert.ToInt32(Console.ReadLine());
            }
            while (b >= count)
            {
                Console.WriteLine("Введите имя:");
                name = Console.ReadLine();
                while(name.Length >= 15)
                {
                    Console.WriteLine("Введите имя, в котром меньше 15 символов :");
                    name = Console.ReadLine();
                }
                Console.WriteLine("Введите фамилию:");
                surename = Console.ReadLine();
                while (surename.Length >= 20)
                {
                    Console.WriteLine("Введите фамилию, в котром меньше 20 символов :");
                    name = Console.ReadLine();
                }
                Console.WriteLine("Введите курс:");
                kurs = Convert.ToInt32(Console.ReadLine());
                while (kurs > 6)
                {
                    Console.WriteLine("Введите курс (целое число от 1 до 5):");
                    name = Console.ReadLine();
                }
                Console.WriteLine("Введите стипендию:");
                pay = Convert.ToInt32(Console.ReadLine());
                student.Add(new Student(name, surename, kurs, pay));
                if(pay > max && kurs == 1)
                {
                    max = pay;
                }
                if(pay > twomax && kurs == 2)
                {
                    twomax = pay;
                }
                if(pay > threemax && kurs == 3)
                {
                    threemax = pay;
                }
                if(pay > fourmax && kurs == 4)
                {
                    fourmax = pay;
                }
                if(pay > fivemax && kurs == 5)
                {
                    fivemax = pay;
                }
                count++;
            }
            foreach (var person in student)
            {
                if (person.Pay >= max && person.Kurs == 1)
                {
                    person.Display();
                }
                else if (person.Pay >= twomax && person.Kurs == 2)
                {
                    person.Display();
                }
                else if (person.Pay >= threemax && person.Kurs == 3)
                {
                    person.Display();
                }
                else if (person.Pay >= fourmax && person.Kurs == 4)
                {
                    person.Display();
                }
                else if (person.Pay >= fivemax && person.Kurs == 5)
                {
                    person.Display();
                }
            }
        }
    }
}