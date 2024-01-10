using task_3;

var player = new Player();
System.Console.Write("Enter player's name: ");
player.Name = System.Console.ReadLine();
System.Console.Write("Enter player's number: ");
player.Number = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Enter player's position: ");
player.Position = System.Console.ReadLine();
System.Console.Write("Enter player's team: ");
player.Team = System.Console.ReadLine();

System.Console.WriteLine();
System.Console.WriteLine(player.GetInfo());
player.ScoreGoal();
var player_name = "Neymar";
player.AssistGoal(player_name);
