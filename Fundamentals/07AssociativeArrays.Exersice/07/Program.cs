
using System.Security.Cryptography.X509Certificates;

string command = String.Empty;

Dictionary<string, Company> database = new Dictionary<string, Company>();
while ((command = Console.ReadLine()) != "End")
{
    string[] array = command.Split(" -> ");
    string company = array[0];
    string employee = array[1];

    if (!database.ContainsKey(company))
    {
        Company currentCompany = new Company(company);
        database.Add(currentCompany.Name, currentCompany);
;    }

    if (database[company].EmployeeList.Contains(employee))
        continue;
    database[company].EmployeeList.Add(employee);

}

foreach (var VARIABLE in database)
{
    Console.WriteLine($"{VARIABLE.Key} {VARIABLE.Value}");
}










class Company

{
  public  Company(string name)
    {
        Name = name;
        EmployeeList = new List<string>();
    }
    public string Name { get; set; }
    public List<string> EmployeeList;

    public override string ToString()
    {
        return $"\n-- {string.Join("\n-- ", EmployeeList).Trim()}";
    }
}