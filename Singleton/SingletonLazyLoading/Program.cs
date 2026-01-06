Singleton singleton = Singleton.Instance;

sealed class Singleton
{

    private static Singleton _instance = default!;

    public static Singleton Instance 
    {
        get
        {
            if(_instance is null) // checks if it's the very first time the instance is requested
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    
    }

    private Singleton()
    {
    }
}

// This implemenation is not thread-safe. In a multi-threaded environment, multiple threads could simultaneously check if _instance
// is null and create multiple instances of the Singleton class.