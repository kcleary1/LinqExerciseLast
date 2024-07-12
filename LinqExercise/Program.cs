using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            var sumOfNumbers = numbers.Sum();

            Console.WriteLine(sumOfNumbers);

            //TODO: Print the Average of numbers
            var averageOfNumbers = numbers.Average(x => x);
            
            Console.WriteLine(averageOfNumbers);

            Console.WriteLine("---------------------");
            
            //TODO: Order numbers in ascending order and print to the console
            var ascendingNumbers = numbers.OrderBy(item => item);
            foreach (var number in ascendingNumbers)
            {

             Console.WriteLine(number); 

            }
            Console.WriteLine("---------------------");
            //TODO: Order numbers in descending order and print to the console
            var descendingNumbers = numbers.OrderByDescending(num => num);
            foreach (var number in descendingNumbers)
            {

                Console.WriteLine(number);
            }
            Console.WriteLine("---------------------");
            //TODO: Print to the console only the numbers greater than 6
            var greaterThan6 = numbers.Where(num => num > 6);
            foreach (var number in greaterThan6)
            {  
                Console.WriteLine(number); 
            }
            Console.WriteLine("---------------------");
            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            foreach (var num in ascendingNumbers.Take(4))
            {
                
                Console.WriteLine(num);
            }
            Console.WriteLine("---------------------");
            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers.SetValue(40, 4);

            var desWithAge = numbers.OrderByDescending(num => num);

            foreach (var number in desWithAge)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("---------------------");
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var filtered = employees.Where(person => person.FirstName.ToLower().StartsWith('c') || person.FirstName.ToLower().StartsWith('s')).OrderBy(person => person.FirstName);
            
            foreach (var person in filtered)
            {

            Console.WriteLine(person.FullName); 
            
            }
            Console.WriteLine("---------------------");
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            var olderThan26 = employees.Where(x => x.Age > 26).OrderByDescending(x => x.Age).ThenBy(x => x.FirstName);

            foreach (var x in olderThan26)
            {

            Console.WriteLine(x.FullName); 
            
            }
            Console.WriteLine("---------------------");
            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var ten35YoEFilter = employees.Where(x => x.Age > 35 && x.YearsOfExperience <= 10);
            var ten35YoEFilterS = ten35YoEFilter.Sum(x => x.YearsOfExperience);

            Console.WriteLine(ten35YoEFilterS);

            Console.WriteLine("---------------------");
            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var ten35YoEFilterA = ten35YoEFilter.Average(x => x.YearsOfExperience);

            Console.WriteLine(ten35YoEFilterA);

            Console.WriteLine("---------------------");
            //TODO: Add an employee to the end of the list without using employees.Add()
            var newEmployee = employees.Append(new Employee("Ash", "Glover", 40, 15)).ToList();

            foreach (var employee in newEmployee)
            {
                Console.WriteLine(employee.FullName);
            }

            Console.WriteLine("---------------------");

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
