using System;

namespace dotnet5Api.BLL.Patterns
{

    public interface InterfaceCheck
    {
        string TryMe(string str);
    }

    // 1) This is Lazy since the instance is created at run time
    // singleton lets you ensure that a class has only one instance, while providing a global access point to it.
    // Sealed restricts the inheritance especially with a Nested class in this case.
    public sealed class Singleton: InterfaceCheck
    {
        // this to prevent instantiation of the class using the default constructor.
        private Singleton() { }

        private static Singleton _instance;

        private static readonly object _lock = new object();

        // property
        public static Singleton GetInstance
        {
            get
            {
                // prevents calling lock by another thread if _instance is already available
                if (_instance == null)
                {
                    // 
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }

        public string TryMe(string str)
        {
            return str;
        }

        private void PrivateCheck()
        {
            // Oh Yeah
        }
    }

    // 2) Eager -> instance is created at compile time
    public sealed class SingletonEager
    {
        private SingletonEager() { }
        private static readonly SingletonEager _instance = new SingletonEager();

        public static SingletonEager GetInstance
        {
            get
            {
                return _instance;
            }
        }
    }

    // 3) Lazy -> instance is created at compile time
    public sealed class SingletonLazy
    {
        private SingletonLazy() { }
        private static readonly Lazy<SingletonLazy> _instance = new Lazy<SingletonLazy>(() => new SingletonLazy());

        public static SingletonLazy GetInstance
        {
            get
            {
                return _instance.Value;
            }
        }
    }

    // Static classes cannot implement interfaces
    public static class StaticVsSingleton
    {
    }
}
