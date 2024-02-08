using _03;

List<BaseEmployee> employees = new List<BaseEmployee>()
{
    new Manager("gogata brat",new List<string>()
    {
        "razvod",
        "nova kyshta",
        "na ivan ishteca",
        "daje ne znam"
    }),
    new Employee("Lelq ti")
};

DetailsPrinter pr = new DetailsPrinter(employees);
pr.PrintDetails();