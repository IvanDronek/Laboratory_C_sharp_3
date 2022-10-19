using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Натисніть будь-яку кнопку для щоб побачити дані про Car");
            Console.ReadKey();

            //Cars
            Car car1 = new Car("Skoda", "Octavia A5", "Black", 12500);
            Car car2 = new Car("Renault", "Alkana", "Red", 22000);
            Car car3 = new Car("KIA", "SPORTAGE FL", "White", 33250);

            car1.Print();
            car1.ChangePrice(10);
            car1.Print();

            car2.Print();
            car2.ChangePrice(10);
            car2.Print();

            car3.Print();
            car3.ChangePrice(10);
            car3.Print();

            Console.WriteLine(car1 == car2);
            Console.WriteLine(car2 == car3);

            Console.WriteLine("Натисніть будь-яку кнопку щоб побачити дані про Person");
            Console.ReadKey();

            //Person
            Person p1 = new Person("Giacomo", 2003);
            Person p2 = new Person("Ben", 1999);
            Person p3 = new Person("Milana", 1994);
            Person p4 = new Person("Tom", 2006);
            Person p5 = new Person("Kate", 2001);
            Person p6 = new Person("Robert", 1997);

            p1.Age();
            p2.Age();
            p3.Age();
            p4.Age();
            p5.Age();
            p6.Age();

            p1.Output();
            p2.Output();
            p3.Output();
            p4.Output();
            p5.Output();
            p6.Output();

            Console.WriteLine(p1 == p6);
            Console.WriteLine(p4 == p6);

            p2.ChangeName("Ivan");
            p2.Output();

            Console.WriteLine("Натисніть будь-яку кнопку щоб закрити консоль");
            Console.ReadKey();
        }
    }
}
