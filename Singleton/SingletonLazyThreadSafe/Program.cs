

sealed class Singleton { 

    private static Singleton _instance = default!;

    public static Singleton Instance
    {
        get
        {
            if(_instance is null)
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