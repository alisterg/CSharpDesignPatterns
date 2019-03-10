using System;

namespace CSharpDesignPatterns.Creational
{
    /// <summary>
    /// An Abstract Factory defines an interface for factory methods
    /// that will return different types of objects. In our example, we
    /// define a CakeFactory interface, which is used to create objects
    /// of (base) type CarrotCake and MudCake. Depending on the concrete 
    /// type of factory (FancyCakeFactory or CheapCakeFactory), these
    /// factory methods will return different subtypes of CarrotCake and
    /// MudCake.
    ///  
    /// TODO test, implement MudCake
    /// 
    /// </summary>
    
    class MainApp
    {
        public void Main(String[] args)
        {
            ICakeFactory cakeFactory;

            switch(args[0])
            {
                case "fancy":
                    cakeFactory = new FancyCakeFactory();
                    break;
                case "cheap":
                    cakeFactory = new CheapCakeFactory();
                    break;
                default:
                    throw new Exception("Invalid factory type!");
            }

            CarrotCake freshCarrotCake = cakeFactory.CreateCarrotCake();
            // can now eat the delicious cheap or fancy carrot cake :)
        }
    }

    interface ICakeFactory
    {
        public abstract CarrotCake CreateCarrotCake();
        public abstract Mudcake CreateMudcake();
    }

    class FancyCakeFactory : ICakeFactory
    {
        public override CarrotCake CreateCarrotCake()
        {
            return new FancyCarrotCake();
        }

        public override MudCake CreateMudcake() {}
    }

    class CheapCakeFactory : ICakeFactory
    {
        public override CarrotCake CreateCarrotCake() 
        {
            return new CheapCarrotCake();
        }

        public override MudCake CreateMudcake() {}
    }
    
    class CarrotCake
    {
        public void BakeTime() 
        {
            Console.WriteLine("Baking regular carrot cake!");
        }
    }

    class FancyCarrotCake : CarrotCake
    {
        public override void BakeTime()
        {
            Console.WriteLine("Baking fancy carrot cake!");
        }
    }

    class CheapCarrotCake : CarrotCake
    {
        public override void BakeTime() 
        {
            Console.WriteLine("Baking cheap carrot cake!");
        }
    }
}