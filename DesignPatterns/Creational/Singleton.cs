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
    /// </summary>
    
    public class MainSingletonApp
    {
        public bool AreInstancesTheSame()
        {
            CakeFactorySingleton cakeFactory1 = CakeFactorySingleton.GetInstance();
            CakeFactorySingleton cakeFactory2 = CakeFactorySingleton.GetInstance();

            return cakeFactory1 == cakeFactory2;
        }
    }

    /// <summary>
    /// The Singleton class
    /// </summary>
    public sealed class CakeFactorySingleton
    {
        private static CakeFactorySingleton _instance;

        private string _secretIngredient;

        // private constructor, we do not want to instantiate this
        // externally
        private CakeFactorySingleton()
        {
            _secretIngredient = "mud";
        }

        public static CakeFactorySingleton GetInstance()
        {
            return _instance ?? (_instance = new CakeFactorySingleton());
        }
    }
}