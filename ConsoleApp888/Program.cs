using System;

namespace ConsoleApp888
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.GetName());
            person.SetName( "Maxim");
            Console.WriteLine(person.GetName());
            person.familya = "Netrebenko";
            person.dateofbirth = new DateTime(2001, 12, 19);
            person.gender = Gender.Female;
            person.Period = TimeFrame.Year;

            Console.WriteLine(person.GetName());
            Console.WriteLine(person.familya);
            Console.WriteLine(person.dateofbirth);
            Console.WriteLine(person.gender);
            Console.WriteLine(person.Period);

        }
    }
}
