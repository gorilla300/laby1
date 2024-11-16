using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp888
{
    class Person
    {
        public Gender gender;
        public TimeFrame Period;
        private string name;
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
        public string GetName()
        {
            return name;
        }
        public void SetName(string value)
        {
            if (Regex.IsMatch(value, "^[А-ЯЁ][а-яё]{2,}$"))
            {
                name = value;
            }
            ////else
            ////{
            ////    throw new Exception("Имя не соответствует формату");
            ////}
        }
        public  Gender GetGender()
        {
            return gender;
        }
        public TimeFrame GetTimeFrame()
        {
            return Period;
        }
        public string Getfamilya()
        {
            return familya;
        }
        public void Setfamilya(string value)
        {
            familya = value;
        }
        public DateTime Getdateofbirth()
        {
            return dateofbirth;
        }
        public void Setdateofbirth(DateTime value)
        {
            dateofbirth = value;
        }
    }
}
