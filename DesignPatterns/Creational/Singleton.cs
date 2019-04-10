using System;

namespace DesignPatterns.Creational.Singleton
{
    /// <summary>
    /// The Singleton principle specifies a type of object
    /// that can only have one instance in a program.
    /// This is a contentious pattern because, if used incorrectly,
    /// causes high coupling between classes. It also introduces 
    /// global state which is best to avoid.
    /// 
    /// A common use is a database connection (so the connection can
    /// be shared / transactions used across classes).
    /// 
    /// TODO test
    /// </summary>
    
    class MainSingletonApp
    {
        public void Run()
        {
            CakeFactorySingleton cakeFactory1 = CakeFactorySingleton.GetInstance();
            CakeFactorySingleton cakeFactory2 = CakeFactorySingleton.GetInstance();

            // They are referring to the same object!
            if (cakeFactory1 == cakeFactory2) 
            {
                Console.WriteLine("They are referring to the same object!");
            }
        }
    }

    /// <summary>
    /// The Singleton class
    /// </summary>
    sealed class CakeFactorySingleton
    {
        private static CakeFactorySingleton _instance;

        // private constructor, we do not want to instantiate this
        // externally
        private CakeFactorySingleton() 
        {
            // do some initialisation
        }

        public static CakeFactorySingleton GetInstance() 
        {
            if(_instance == null) 
            {
                _instance = new CakeFactorySingleton();
            }

            return _instance;
        }
    }
}