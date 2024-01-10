
using task_4;

var actor = new Actor("Robert Downey Jr.", 56, "Male");

System.Console.WriteLine($"Actor's Name: Robert Downey Jr.");
System.Console.WriteLine("age : " + actor.GetAge());
System.Console.WriteLine("Gender : " + actor.GetGender());

actor.AddMovie("1.Iron Man");
actor.AddMovie("2.Avengers: Endgame");
System.Console.WriteLine("3.Sherlock Holmes");

System.Console.WriteLine("Movies Played by Robert Downey Jr.:");
foreach (var item in actor.moviesPleyed)
{
    System.Console.WriteLine(item);
}
