

System.Console.Write("Enter date : ");
string date = System.Console.ReadLine();

var parsedDate = DateTime.Parse(date);

System.Console.WriteLine(DateTime.Parse(date));

System.Console.WriteLine(DateTime.UtcNow.Day - parsedDate.Day);


