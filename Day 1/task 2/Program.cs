

using task_2;

var post = new Post();
post.Text = System.Console.ReadLine();
post.AddLike();
post.AddLike();

post.AddComment("Super");

System.Console.WriteLine(post.GetInfo());

foreach (var item in post.Comments)
{
    System.Console.WriteLine(item);
}
