using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// The Factory Method is a method that will create an object
    /// of a specific type or a specific state.
    /// 
    /// Benefits: Decouples the instantiation from the implementer. 
    /// Allows greater adherence to the Open/Closed principle and 
    /// Dependency Inversion principle.
    /// </summary>
    public class MainFactoryApp
    {
        public ICake Main()
        {
            CarrotCakeMaker cakeMaker = new CarrotCakeMaker();
            
            ICake myCake = cakeMaker.MakeCake();

            return myCake;
            // can now eat the delicious Carrot cake :)
        }
    }

    public interface ICake
    {
        string BakeTime();
    }

    public class CarrotCake : ICake
    {
        public string BakeTime()
        {
            return "Baking carrot cake!";
        }
    }

    public class MudCake : ICake
    {
        public string BakeTime()
        {
            return "Baking mudcake!";
        }
    }

    public abstract class CakeMaker
    {
        /// <summary>
        /// The factory method, which we will override
        /// to produce a new instance of a concrete Cake
        /// </summary>
        /// <returns>
        /// Some type of concrete Cake
        /// </returns>
        public abstract ICake MakeCake();
    }

    public class CarrotCakeMaker : CakeMaker
    {
        /// <summary>
        /// A concrete factory method
        /// </summary>
        /// <returns>
        /// An instance of CarrotCake
        /// </returns>
        public override ICake MakeCake()
        {
            return new CarrotCake();
        }
    }

    public class MudCakeMaker : CakeMaker
    {
        /// <summary>
        /// Another concrete factory method
        /// </summary>
        /// <returns>
        /// An instance of MudCake
        /// </returns>
        public override ICake MakeCake()
        {
            return new MudCake();
        }
    }
}