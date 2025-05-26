namespace design_patterns_console.Singleton.Db;

public interface User
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class DatabaseClassic
{
    private static DatabaseClassic? _instance;
    private List<User> Users = new List<User>();
    private DatabaseClassic()
    { }

    public static DatabaseClassic GetInstance()
    {
        if (_instance == null)
        {
            _instance = new DatabaseClassic();
        }
        return _instance;
    }

    public void AddUser(User user)
    {
        Users.Add(user);
    }

    public void RemoveUser(int index)
    {
        Users.RemoveRange(index, 1);
    }

    public void Show()
    {
        foreach (var user in Users)
        {
            Console.WriteLine(user);
        }
    }
}

/*
const dbClassic = DatabaseClassic.GetInstance();
dbClassic.AddUser({Name = "Alice", Age = 18 });
dbClassic.AddUser({Name = "Luiz", Age = 50 });
dbClassic.AddUser({Name = "Maria", Age = 30 });
dbClassic.Show();
dbClassic.RemoveUser(1); // Remove Luiz
dbClassic.Show();
*/