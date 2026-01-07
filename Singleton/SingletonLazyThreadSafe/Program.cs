

sealed class Singleton {

    private static readonly object _lock = new();

    private static Singleton _instance = default!;


    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance is null)
                    {
                        _instance = new Singleton();
                    }
                }
            }

            return _instance;
        }
    
    }


    private Singleton()
    {
    }


}