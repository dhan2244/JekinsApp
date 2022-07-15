using System;
using MyMaths;

namespace JekinsApp
{
    class main
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Welcome to Jenkins");
            //Console.WriteLine("Hello Dhanush");

            //Console.WriteLine("Welcome to my Console App 1.0");
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("Choose the option for operation");
            //Console.WriteLine("1. Add Two integers");
            //Console.WriteLine("2. Multiply Two Integers");
            //Console.WriteLine("3. Exit");
            //Console.WriteLine("--------------------------------");

            //int choice = Convert.ToInt32(Console.ReadLine());
            //Maths maths = new Maths();
            int res = 0; 
            bool f = true;
            while(f)
            {
                Console.WriteLine("Welcome to my Console App 1.0");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Choose the option for operation");
                Console.WriteLine("1. Add Two integers");
                Console.WriteLine("2. Multiply Two Integers");
                Console.WriteLine("3. Exit");
                Console.WriteLine("--------------------------------");

                int choice = Convert.ToInt32(Console.ReadLine());
                Maths maths = new Maths();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the first number to be added");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number to be added");
                        int b = Convert.ToInt32(Console.ReadLine());
                        res = maths.Add(a, b);
                        break;
                    case 2:
                        Console.WriteLine("Enter the first number to be multiplied");
                        int a1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number to be multiplied");
                        int b1 = Convert.ToInt32(Console.ReadLine());
                        res = maths.Multiply(a1, b1);
                        break;
                    case 3:
                        Console.WriteLine("Exited the App, Thank you :)");
                        f = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                if(f)
                Console.WriteLine("The result of your operation is " + res);

            }
            
            //Console.WriteLine("The result of your operation is " + res);
            Console.ReadLine();
        }
    }
}
