using System;
using System.Collections.Generic;
using System.Linq;

int n = int.Parse(Console.ReadLine());
int howManyDepartments = 0;
int numberOfEachDepartment = 0;
double totalSalaryinEach = 0;
List<Departments> departments = new List<Departments>();
List<Employee> employees = new List<Employee>();

for (int i = 0; i < n; i++)
{
    Departments departmentInitialize = new Departments();
    string[] array = Console.ReadLine().Split();
    string name = array[0];
    double salary = double.Parse(array[1]);
    string department = array[2];

    // Check if there is an existing department with the same name
    var existingDepartment = departments.FirstOrDefault(d => d.Department == department);

    if (existingDepartment != null)
    {
        // Increment the department's employee count and total salary
        existingDepartment.Number++;
        existingDepartment.TotalSalary += salary;
    }
    else
    {
        // Create a new department and add it to the list
        departmentInitialize.Department = department;
        departmentInitialize.Number = 1;
        departmentInitialize.TotalSalary += salary;
        departments.Add(departmentInitialize);
    }

    Employee employee = new Employee(name, salary, department);
    employees.Add(employee);
}

// Find the department with the highest total salary
double maxSalary = departments.Max(x => x.TotalSalary);
var biggestDepartment = departments.First(x => x.TotalSalary == maxSalary);

// Find employees in the biggest department
List<Employee> finalEmployees = employees.Where(e => e.Department == biggestDepartment.Department).ToList();

// Sort the employees by salary
finalEmployees = finalEmployees.OrderByDescending(e => e.Salary).ToList();

// Print the employees
Console.WriteLine($"Highest Average Salary: {biggestDepartment.Department}");
foreach (Employee employee in finalEmployees)
{
    Console.WriteLine(employee);
}

class Departments
{
    public string Department { get; set; }
    public int Number { get; set; }
    public double TotalSalary { get; set; }
}

class Employee
{
    public Employee(string name, double salary, string department)
    {
        Name = name;
        Salary = salary;
        Department = department;
    }

    public string Name { get; set; }
    public double Salary { get; set; }
    public string Department { get; set; }

    public override string ToString()
    {
        return $"{Name} {Salary:f2}";
    }
}