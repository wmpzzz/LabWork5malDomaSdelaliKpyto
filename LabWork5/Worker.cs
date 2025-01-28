using System.Diagnostics.Metrics;

public class Worker
{
    private string _fullName = "unknown";
    private string _post = "unknown";
    private int _salary = 0;


    public Worker() : this("Kravchuck Mikhail Sergeevich", "cleaning manager", 10000000)
    {
    }

    public Worker(string fullName, string post, int salary)
    {
        FullName = fullName;
        Post = post;
        Salary = salary;
    }

    public string FullName 
    { get => _fullName;
      set
        {
            if (value != "" )
                _fullName = value;
        }
    }

    public string Post
    {
        get => _post;
        set
        {
            if (value != "")
                _post = value;
        }
    }

    public int Salary
    {
        get => _salary;
        set
        {
            if (value >= 0)
                _salary = value;
        }
    }

    public void Print()
    {
        Console.WriteLine($"name: {FullName}");
        Console.WriteLine($"post: {Post}");
        Console.WriteLine($"salary: {Salary}");
    }
}