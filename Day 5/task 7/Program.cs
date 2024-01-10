
System.Console.Write("Please enter word : ");
string word;
int cnt = 0;

bool stop = true;

while (stop)
{
    word = System.Console.ReadLine();
    if (word == "end" || word == "End")
    {
        stop = false;
        break;
    }
    System.Console.WriteLine(word);
    cnt++;
}

