namespace task_2;

public class Post
{

    public string Text { get; set; }
    public int Likes { get; set; }
    public List<string> Comments { get; set; }

    public void SetPost(string _text)
    {
        Text = _text;
    }
    public void AddLike()
    {
        Likes++;
    }
    public void AddComment(string comment)
    {
        Comments.Add(comment);
    }

    public string GetInfo()
    {
        return $"text : {Text}\nLikes : {Likes}\n\nComments : \n";
    }






}
