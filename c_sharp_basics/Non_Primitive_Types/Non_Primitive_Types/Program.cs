using Non_Primitive_Types.Math;
using System;

namespace Non_Primitive_Types
{ 
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
        //var john = new Person();
        //john.FirstName = "John";
        //john.LastName = "Smith";
        //john.Introduce();

        //Calculator calculator = new Calculator();
        //var result = calculator.Add(1, 2);
        //Console.WriteLine(result);

        //var numbers = new int[3];
        //numbers[0] = 1;

        //Console.WriteLine(numbers[0]);
        //Console.WriteLine(numbers[1]);
        //Console.WriteLine(numbers[2]);

        //var flags = new bool[3];
        //flags[0] = true;

        //Console.WriteLine(flags[0]);
        //Console.WriteLine(flags[1]);
        //Console.WriteLine(flags[2]);

        //var names = new string[3] { "Jack", "John", "Mary" };

        //33. Demo: Strings
        //            var firstName = "Ryan";
        //            var lastName = "Waszak";

        //            var fullName = firstName + " " + lastName;

        //            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

        //            var names = new string[3] { "John", "Jack", "Mary" };
        //            var formattedNames = string.Join(",", names);

        //            var text = @"Hi John
        //            Look into the following paths
        //c:\folder1\folder2
        //c:\folder3\folder4";

        //            Console.WriteLine(text);


        //35. Demo:Enums
        //public enum defined in this namespace outside of main method!
        var method = ShippingMethod.Express;
        Console.WriteLine((int)method);

        var methodId = 3;
        Console.WriteLine((ShippingMethod)methodId);

        Console.WriteLine(method.ToString());

        var methodName = "Express";
        var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);

        }
    }
}
