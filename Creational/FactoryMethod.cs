using System;

namespace CSharpDesignPatterns.Creational
{
    /// <summary>
    /// The Factory Method is a method that will create an object
    /// of a specific type or a specific state.
    /// </summary>

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
        public Cake MakeCake()
        {
            return new CarrotCake();
        }
    }

    class MudCakeMaker : CakeMaker
    {
        public Cake MakeCake()
        {
            return new MudCake();
        }
    }
}