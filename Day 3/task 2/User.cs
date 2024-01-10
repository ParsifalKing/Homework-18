namespace task_2;

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    string Password;


    public void GetInfo()
    {
        System.Console.WriteLine($"Login successful! Welcome, Mr./Ms. {FirstName} {LastName}");

    }
    public void Login(string username, string password)
    {
        if (username == UserName && password == Password)
        {
            System.Console.WriteLine("Пользователь успешно зарегистрирован");
        }
        else
        {
            System.Console.WriteLine("Ваш пароль или имя пользователя неверны");
        }
    }


}
