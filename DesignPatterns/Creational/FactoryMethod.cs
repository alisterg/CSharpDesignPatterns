using System;

namespace DesignPatterns.Creational.Factory
{
    /// <summary>
    /// The Factory Method is a method that will create an object
    /// of a specific type or a specific state.
    /// 
    /// Benefits: Decouples the instantiation from the implementer. 
    /// Allows greater adherence to the Open/Closed principle and 
    /// Dependency Inversion principle.
    /// 
    /// TODO test
    /// </summary>
    
    class MainFactoryApp
    {
        public void Main()
        {
            CarrotCakeMaker cakeMaker = new CarrotCakeMaker();
            
            Cake myCake = cakeMaker.MakeCake();
            // can now eat the delicious Carrot cake :)
        }
    }

    interface Cake
    {
        void BakeTime();
    }

    class CarrotCake : Cake
    {
        public void BakeTime()
        {
            Console.Write("Baking carrot cake!");
        }
    }

    class MudCake : Cake
    {
        public void BakeTime()
        {
            Console.Write("Baking mudcake!");
        }
    }

    abstract class CakeMaker
    {
        /// <summary>
        /// The factory method, which we will override
        /// to produce a new instance of a concrete Cake
        /// </summary>
        /// <returns>
        /// Some type of concrete Cake
        /// </returns>
        public abstract Cake MakeCake();
    }

    class CarrotCakeMaker : CakeMaker
    {
        public override Cake MakeCake()
        {
            return new CarrotCake();
        }
    }

    class MudCakeMaker : CakeMaker
    {
        public override Cake MakeCake()
        {
            return new MudCake();
        }
    }
}