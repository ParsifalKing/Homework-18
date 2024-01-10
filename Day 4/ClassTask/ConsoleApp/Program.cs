

using Domain.Models;
using Infrasturture.Services;

var group = new Group();
group.Name = "C#";
group.Id = 1;
group.Description = "Well down";

var group2 = new Group();
group2.Name = "C++";
group2.Id = 2;
group2.Description = "Good";

var grService = new GroupService();
grService.CreateGroup(group);
grService.CreateGroup(group2);

foreach (var item in grService.groups)
{
    System.Console.WriteLine(item.Name);
    System.Console.WriteLine(item.Description);
}

System.Console.WriteLine();
System.Console.WriteLine(grService.DeleteGroup(1));
System.Console.WriteLine();


foreach (var item in grService.groups)
{
    System.Console.WriteLine(item.Name);
    System.Console.WriteLine(item.Description);
}