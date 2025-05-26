namespace design_patterns_console.Singleton.Examples;

public sealed class Singleton
{
    private static Singleton _instance;
    private Singleton()
    {
        // Construtor privado para impedir instância externa
    }

    public static Singleton Instance
    {
        get
        {
            // Verifica se a instância já foi criada
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}

/*
var instance1 = Singleton.Instance;
var instance2 = Singleton.Instance;

Console.WriteLine(typeof(instance1 == instance2)); // true
*/
