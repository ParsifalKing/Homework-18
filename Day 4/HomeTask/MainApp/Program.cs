using Domain.Models;
using Infostructure.Services;

var DepartService = new DepartmentService();
System.Console.WriteLine("------------DEPARTMENTS------------");

while (true)
{
    System.Console.WriteLine("Choose one command :  list, add, edit, delete, exit");

    string command = System.Console.ReadLine();

    if (command == "list")
    {
        foreach (var item in DepartService.GetDepartments())
        {
            System.Console.Write("Department ID : ");
            System.Console.WriteLine(item.Id);
            System.Console.Write("Department name : ");
            System.Console.WriteLine(item.Name);
            System.Console.Write("Department description : ");
            System.Console.WriteLine(item.Description);
            System.Console.WriteLine();
        }
    }
    else if (command == "add")
    {
        var department1 = new Department();
        System.Console.Write("Enter id : ");
        department1.Id = Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Enter department's name : ");
        department1.Name = System.Console.ReadLine();
        System.Console.Write("Enter department's description : ");
        department1.Description = System.Console.ReadLine();
        DepartService.AddDepartments(department1);

    }
    else if (command == "edit")
    {
        var department1 = new Department();
        System.Console.Write("Enter id : ");
        department1.Id = Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Enter department's name : ");
        department1.Name = System.Console.ReadLine();
        System.Console.Write("Enter department's description : ");
        department1.Description = System.Console.ReadLine();
        System.Console.WriteLine(DepartService.UpdateDepartments(department1));
    }
    else if (command == "delete")
    {
        System.Console.Write("Enter id : ");
        int id = Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine(DepartService.DeleteDepartments(id));
    }
    else if (command == "exit")
    {
        break;
    }
}
System.Console.Write("Department's number : ");
System.Console.WriteLine(DepartService.CountDepartments());




// Employee ----------------------

var EmpService = new EmployeeService();
System.Console.WriteLine("------------EMPLOYEES------------");

while (true)
{
    System.Console.WriteLine("Choose one command :  list, add, edit, delete, exit");

    string command = System.Console.ReadLine();

    if (command == "list")
    {
        foreach (var item in EmpService.GetEmployees())
        {
            System.Console.Write("Employee : ");
            System.Console.WriteLine(item.Id);
            System.Console.Write("Employee's name : ");
            System.Console.WriteLine(item.FirstName);
            System.Console.Write("Employee's surname : ");
            System.Console.WriteLine(item.LastName);
            System.Console.Write("Employee's birthday : ");
            System.Console.WriteLine(item.BirthDate);
            System.Console.WriteLine("--------------------");
        }
    }
    else if (command == "add")
    {
        var employee1 = new Employee();
        System.Console.Write("Enter employee ID : ");
        employee1.Id = Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Enter employee name : ");
        employee1.FirstName = System.Console.ReadLine();
        System.Console.Write("Enter employee surname : ");
        employee1.LastName = System.Console.ReadLine();
        System.Console.Write("Enter employee birthday : ");
        employee1.BirthDate = Convert.ToInt32(System.Console.ReadLine());
        EmpService.AddEmployees(employee1);
    }
    else if (command == "edit")
    {
        var employee1 = new Employee();
        System.Console.Write("Enter employee ID : ");
        employee1.Id = Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Enter employee name : ");
        employee1.FirstName = System.Console.ReadLine();
        System.Console.Write("Enter employee surname : ");
        employee1.LastName = System.Console.ReadLine();
        System.Console.Write("Enter employee birthday : ");
        employee1.BirthDate = Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine(EmpService.UpdateEmployees(employee1));
    }
    else if (command == "delete")
    {
        System.Console.Write("Enter employee ID : ");
        int id = Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine(EmpService.DeleteEmployees(id));
    }
    else if (command == "exit")
    {
        break;
    }
}
System.Console.Write("Employee's number : ");
System.Console.WriteLine(EmpService.CountEmployees());
