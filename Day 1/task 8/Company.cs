using task_8;

namespace task_8;
public class Company : Employee
{
    public string CompanyName { get; set; }
    public string Location { get; set; }
    public string CEO { get; set; }
    public int NumberOfEmployees { get; set; }
    public float Revenue { get; set; }
    public List<string> Employees = new List<string>();


    public void HireEmployee(string employeeName)
    {
        Employees.Add(employeeName);
        NumberOfEmployees++;
    }
    public void FireEmployee(string employeeName)
    {
        Employees.Remove(employeeName);
        NumberOfEmployees--;
    }

    public string GenerateAnnualReport()
    {
        return $"Company Name: {CompanyName} \nLocation: {Location} \nCEO: {CEO}\nNumber of Employees: {NumberOfEmployees}\nRevenue: {Revenue}";
    }



}
