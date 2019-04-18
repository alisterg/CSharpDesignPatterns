using System;

namespace DesignPatterns.Creational.AbstractFactory
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
    /// </summary>
    public class MainAbstractFactoryApp
    {
        public CarrotCake Main(string[] args)
        {
            ICakeFactory cakeFactory;

            switch (args[0])
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
            
            return freshCarrotCake;
            // can now eat the delicious cheap or fancy carrot cake :)
        }
    }

    /// <summary>
    /// The abstract factory - implementers will return a
    /// different category of objects for each factory method
    /// </summary>
    public interface ICakeFactory
    {
        /// <summary>
        /// An abstract factory method
        /// </summary>
        /// <returns>
        /// Returns a carrot cake of type depending on
        /// the implementer
        /// </returns>
        CarrotCake CreateCarrotCake();
        MudCake CreateMudcake();
    }

    public class FancyCakeFactory : ICakeFactory
    {
        public CarrotCake CreateCarrotCake()
        {
            return new FancyCarrotCake();
        }

        public MudCake CreateMudcake()
        {
            return new MudCake();
        }
    }

    public class CheapCakeFactory : ICakeFactory
    {
        public CarrotCake CreateCarrotCake()
        {
            return new CheapCarrotCake();
        }

        public MudCake CreateMudcake()
        {
            return new MudCake();
        }
    }

    public class CarrotCake
    {
        public virtual string BakeTime()
        {
            return "Baking regular carrot cake!";
        }
    }

    public class FancyCarrotCake : CarrotCake
    {
        public override string BakeTime()
        {
            return "Baking fancy carrot cake!";
        }
    }

    public class CheapCarrotCake : CarrotCake
    {
        public override string BakeTime()
        {
            return "Baking cheap carrot cake!";
        }
    }

    public class MudCake
    {
    }
}