using System;

namespace lab_repo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var person1 = new person();
            person1.DateOfBirth = DateTime.Now;
            person1.SayHellow();
            var emp1 = new Employee();
            emp1 = (Employee)person1;
            emp1.DateOfBirth = DateTime.Now;
            System.Console.WriteLine(emp1.DateOfBirth);


        }
    }
}
