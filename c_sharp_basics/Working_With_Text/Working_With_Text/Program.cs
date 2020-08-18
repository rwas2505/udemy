using System;

namespace Working_With_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            //64.Demo: String

            var fullName = "Ryan Waszak ";
            Console.WriteLine("Trim : '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper : '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($" Last name: {lastName}");

            var names = fullName.Split(' ');
            Console.WriteLine($"First name: {names[0]}");
            Console.WriteLine($" Last name: {names[1]}");

            var newName = fullName.Replace("Ryan", "Ryan David");
            Console.WriteLine(newName);

            if (String.IsNullOrWhiteSpace(""))
                Console.WriteLine("INVALID");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));

            
        }
    }
}
