using System;
using System.Text.RegularExpressions;

namespace regexTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing IsName");
            Console.WriteLine(IsName("Joshua"));
            Console.WriteLine(IsName("not a name"));
            Console.WriteLine("Testing IsPhoneNumber");
            Console.WriteLine(IsPhoneNumber("123-456-7890"));
            Console.WriteLine(IsPhoneNumber("911"));
            Console.WriteLine("Testing IsEmail");
            Console.WriteLine(IsEmail("john_doe@gmail.com"));
            Console.WriteLine(IsEmail("fakeemail@fake.fake"));
            Console.WriteLine("Testing IsDate");
            Console.WriteLine(IsDate("01/25/2021"));
            Console.WriteLine(IsDate("2020 sucks"));
            Console.WriteLine("Testing IsHRML");
            Console.WriteLine(IsHTML("<p>This tag is great</p>"));
            Console.WriteLine(IsHTML("<p>This tag is bad<>"));
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
            return Regex.IsMatch(s, "^[\\d\\w_]{5,30}@[\\w\\d]{5,10}\\.[\\w\\d]{2,3}$");
        }

        // phone number must be in a format of DDD-DDD-DDDD
        public static bool IsPhoneNumber(string s)
        {
            return Regex.IsMatch(s, "^\\d{3}-\\d{3}-\\d{4}$");
        }

        // date must be in a format dd/mm/yyyy
        public static bool IsDate(string s)
        {
            return Regex.IsMatch(s, "^\\d{2}/\\d{2}/\\d{4}$");
        }

        // html tag must be in format <h1> content </h1>
        public static bool IsHTML(string s)
        {
            return Regex.IsMatch(s, "^<!?\\w>[\\w\\s]*</\\w>$");
        }


    }
}
