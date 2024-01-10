

using task_4;

var employee = new Employee();
System.Console.Write("Enter employee's FirstName: ");
employee.FirstName = System.Console.ReadLine();
System.Console.Write("Enter employee's LastName: ");
employee.LastName = System.Console.ReadLine();
System.Console.Write("Enter employee's Age: ");
employee.Age = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Enter employee's Position: ");
employee.Position = System.Console.ReadLine();
System.Console.Write("Enter employee's Salary: ");
employee.Salary = Convert.ToDecimal(System.Console.ReadLine());


System.Console.WriteLine(employee.GetInfo());
System.Console.WriteLine();

System.Console.Write("Set a new Salary: ");
employee.Salary = Convert.ToDecimal(System.Console.ReadLine());
System.Console.WriteLine();

System.Console.WriteLine(employee.GetInfo());
System.Console.WriteLine();

