using System;

namespace TaxCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter salary: ");
            var input = Console.ReadLine();

            //validations
            input = IsNumberValidation(input);
            input = IsPositiveNumberValidation(input);

            var accountant = new Accountant();
            var salary = decimal.Parse(input);
            salary = accountant.TaxSalary(salary);

            Console.WriteLine("Salary aftar taxation is: {0}", salary);
            Console.ReadLine();
        }

       
        private static string IsPositiveNumberValidation(string input)
        {
            while (Validator.IsPositiveNumber(input))
            {

                Console.Clear();
                Console.WriteLine("Salary cannot be a negative number");
                Console.WriteLine("Please enter salary: ");
                input = Console.ReadLine();

                input = IsNumberValidation(input);
            }

            return input;
        }

        private static string IsNumberValidation(string input)
        {
            while (!Validator.IsNumber(input))
            {
                Console.Clear();
                Console.WriteLine("The provided data is not a valid number.");
                Console.WriteLine("Please enter salary: ");
                input = Console.ReadLine();
            }

            return input;
        }
    }
}
