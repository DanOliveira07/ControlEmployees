using System;
using System.Globalization;
using System.Collections.Generic;

namespace ListasFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter with a number of repeats in the looping = number of registereds employees
            Console.Write("How many employees will be registered? ");
            int CountRegister = int.Parse(Console.ReadLine());

            // Initializing a new List
            List<Employees> list = new List<Employees>();

            // Looping For/FOR call the constructor and get atributes of the employees
            for (int i = 1; i <= CountRegister; i++)
            {
                Console.WriteLine($"Employee #{i}: ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employees(id, name, salary));
                Console.WriteLine();
            }
                        // Condicional structure for ask if you want increase any salary
            Console.Write("Do you want to increase any salary?(Y/N)");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 'Y' || resp == 'y')
            {   // Enter with a password
                Console.WriteLine("Enter the password: ");
                string pass = Console.ReadLine();
                if (pass == "Dan159")
                {
                    Console.Write("How many updates do you have go do? ");
                    int nUpdates = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= nUpdates; i++)
                    {
                        // Search if the Id already exist in list
                        Console.Write("Enter the employee ID that will have salary increase: ");
                        int Idsearch = int.Parse(Console.ReadLine());

                        Employees emp = list.Find(x => x.Id == Idsearch);
                        if (emp != null)
                        {   // Enter with the percentage that you want to by increasing the salary
                            Console.Write("Enter the percentage: ");
                            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            emp.increaseSalary(percentage);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("The id is not registered or not exist!");
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("PASS INCORRECT!");
                }
            }
            // Print a list of updateds employees
            Console.WriteLine("Updated list of employees: ");
            foreach (Employees obj in list)
            {
                Console.WriteLine(obj);
            }

            // Do a remove for a especific employee
            Console.WriteLine("Do you want remove any employee?(Y/N)");
            resp = char.Parse(Console.ReadLine());
            if (resp == 'Y' || resp == 'y')
            {
                Console.Write("Enter the Password: ");
                string pass = Console.ReadLine();
                if (pass == "DanAdm")
                {
                    Console.WriteLine("How many employees you want remove? ");
                    int nRemoves = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= nRemoves; i++)
                    {
                        Console.Write("Enter the employee ID that will be removed: ");
                        int Idsearch = int.Parse(Console.ReadLine());

                        Employees emp = list.Find(x => x.Id == Idsearch);
                        if (emp != null)
                        {   // remove employees
                            list.Remove(emp);
                            Console.WriteLine(emp.Name + " has been Removed!");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("The ID is not registered or not exist!");
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Pass Incorrect!");
                    Console.WriteLine();
                }
            }
            // Print a list of updateds employees
            Console.WriteLine("Updated list of employees: ");
            foreach (Employees obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
