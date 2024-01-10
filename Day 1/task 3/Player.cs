namespace task_3;

public class Player
{

    public string Name { get; set; }
    public int Number { get; set; }
    public string Position { get; set; }
    public string Team { get; set; }

    public void ScoreGoal()
    {
        System.Console.WriteLine($"Player {Number} {Name} scores a goal.");
    }
    public void AssistGoal(string player_name)
    {
        System.Console.WriteLine($"Player {Number} {Name} assist a goal for {player_name}");
    }
    public string GetInfo()
    {
        return $"Name : {Name} \nNumber : {Number} \nPosition : {Position} \nTeam : {Team}";
    }
}
