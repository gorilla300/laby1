using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp888
{
    class Person
    {
        public Gender gender;
        public TimeFrame Period;
        public string name;
        public string familya;
        public DateTime dateofbirth;

        public Person()
        {
            name = "Maxim";
            familya = "Netrebenko";
            dateofbirth = new DateTime(2001, 12, 19);
        }
        public string ToFullString()
        {
            return $"Имя: {name}, фамилия: {familya} день рождения {dateofbirth}";
        }
        public string GetNmae()
        {
            return name;
        }
    }
}
