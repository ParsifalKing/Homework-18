namespace task_6;

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool IsLoggedIn { get; set; }

    void Login(string username, string password)
    {
        if (username == UserName && password == Password)
        {
            System.Console.WriteLine("Пользователь успешно зарегистрирован");
            IsLoggedIn = true;
        }
        else
        {
            System.Console.WriteLine("Ваш пароль или имя пользователя неверны");
        }
    }
    void Logout()
    {
        IsLoggedIn = false;
    }

    string GetFullInfo()
    {
        return $"{FirstName} {LastName} - {IsLoggedIn} ";

    }
}
