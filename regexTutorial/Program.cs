using System;
using System.Text.RegularExpressions;

namespace regexTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsName("Joshua"));
            Console.WriteLine(IsPhoneNumber("123-456-7890"));
            Console.WriteLine(IsEmail("johndoes@gmail.com"));
            Console.WriteLine(IsDate("01/25/2021"));
            Console.WriteLine(IsHTML("<p>This tag is great</p>"));
        }


        // name must be in format capital letter , followed by only letters, max 30
        public static bool IsName(string s)
        {
            return Regex.IsMatch(s,"^[A-Z]{1}[a-z]{0,29}$");
        }


        // email must be in a format of:
        // {alphanumeric charcters length 5-30}@{alphanumeric characters length of 5-10}.{alphanumeric characters length 2-3}
        public static bool IsEmail(string s)
        {
            return Regex.IsMatch(s, "^[a-zA-Z0-9]{5,30}@[a-zA-Z0-9]{5,10}\\.[a-zA-Z0-9]{2,3}$");
        }

        // phone number must be in a format of DDD-DDD-DDDD
        public static bool IsPhoneNumber(string s)
        {
            return Regex.IsMatch(s,"^[0-9]{3}-[0-9]{3}-[0-9]{4}$");
        }

        // date must be in a format dd/mm/yyyy
        public static bool IsDate(string s)
        {
            return Regex.IsMatch(s, "^[0-9]{2}/[0-9]{2}/[0-9]{4}$");
        }

        // html tag must be in format <h1> content </h1>
        public static bool IsHTML(string s)
        {
            return Regex.IsMatch(s, "^<!?[A-Za-z0-9]>[A-za-z0-9 ]*</[A0Za-z0-9]>$");
        }


    }
}
