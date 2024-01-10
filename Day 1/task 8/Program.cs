using task_8;

var company = new Company();
System.Console.Write("Enter company name: ");
company.CompanyName = System.Console.ReadLine();
System.Console.Write("Enter company location: ");
company.Location = System.Console.ReadLine();
System.Console.Write("Enter CEO name: ");
company.CEO = System.Console.ReadLine();
System.Console.Write("Enter number of employee : ");
company.NumberOfEmployees = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Enter annual revenue : ");
company.Revenue = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine();


System.Console.WriteLine(company.GenerateAnnualReport());
System.Console.WriteLine();

var hireEmployee = "Alice";
company.HireEmployee(hireEmployee);
System.Console.WriteLine($"Hire a new employee: {hireEmployee}");
hireEmployee = "Bob";
company.HireEmployee(hireEmployee);
System.Console.WriteLine($"Hire a new employee: {hireEmployee}");
var fireEmployee = "Alice";
company.FireEmployee(fireEmployee);
System.Console.WriteLine($"Hire a new employee: {fireEmployee}");
System.Console.WriteLine();

System.Console.WriteLine(company.GenerateAnnualReport());
System.Console.WriteLine();






