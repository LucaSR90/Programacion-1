using System;

public class Logger
{
    private static Logger _instance;
    private static readonly object _lock = new object();

    private Logger() { }  // Constructor privado para evitar instancias externas.

    public static Logger Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }
    }

    public void Log(string message)
    {
        Console.WriteLine($"LOG: {message}");
    }
}

class Program
{
    static void Main()
    {
        Logger log1 = Logger.Instance;
        Logger log2 = Logger.Instance;

        log1.Log("Esto es un mensaje de log.");

        // Ambas referencias apuntan al mismo objeto
        Console.WriteLine(ReferenceEquals(log1, log2)); // Imprime 'True'
    }
}
