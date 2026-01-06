using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiveSingleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }


        // A consumer of a Singleton class have to be able to access its single instance.
        Singleton singleton = Singleton.Instance;

        sealed class Singleton // Sealed to prevent inheritance
        {

            public static Singleton Instance { get; } = new Singleton(); //No set option, so it is read-only

            private Singleton() // Private constructor to prevent instantiation from outside the class
            {
            }
        }


        // Above initialization problem is that the instance will be created in a "eager" way, 
        // which means that it will be created, with all of its properties, even if it is never used.
        // Another problem is that we can't know when exactly the compiler will invoke the instance creation, since it is handled by the runtime.







    }
}
