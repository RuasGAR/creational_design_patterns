Singleton singleton = Singleton.Instance;

sealed class Singleton
{

    private static readonly Lazy<Singleton> _lazyInstance = new(() => new Singleton());

    // Lazy <T> ensures thread-safe lazy initialization, a "all in one" solution.
    public static Singleton Instance 
    {
        get
        {
            return _lazyInstance.Value;
        }
    }

}