namespace ProperSingleton
{
    sealed class CoolSingleton
    {
        public static string ClassName = "CoolSingleton";

        public static CoolSingleton Instance => Nested.Instance;

        private class Nested
        {
            internal static CoolSingleton Instance { get; } = new();
            static Nested() 
            {
            }
        }

        static CoolSingleton()
        {
        }
    }
}
