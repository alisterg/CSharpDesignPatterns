using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioural.TemplateMethod
{
    /// <summary>
    /// The Template Method pattern uses a skeleton method in a base class in combination
    /// with abstract or "hook" methods, which subclasses can override to make the 
    /// skeleton method (the Template Method) perform different behaviours.
    /// This is a common pattern to use when refactoring to reduce duplicate code.
    /// </summary>
    public class MainTemplateMethodApp
    {
        public void Run()
        {
            var blankCake = new CarrotCake();
            var cooker = new CarrotCakeCooker(blankCake);

            var finalResult = cooker.Cook();

            // now we can enjoy a delicious cake!!
        }
    }

    public class Cake 
    { 
        public string SecretIngredient { get; set; }
    }

    public class CarrotCake : Cake {}
    public class MudCake : Cake {}

    public abstract class CakeCooker
    {
        protected Cake _cake;

        public CakeCooker(Cake cake)
        {
            _cake = cake;
        }

        /// <summary>
        /// Our abstract methods that all classes have to implement
        /// </summary>
        protected abstract void PrepareBatter();
        protected abstract void Bake();

        /// <summary>
        /// A "hook" method which we can choose to leave empty or override
        /// </summary>
        protected virtual void FinalStep() { }

        /// <summary>
        /// The Template Method
        /// </summary>
        public Cake Cook()
        {
            PrepareBatter();
            Bake();
            FinalStep(); // Does nothing, subclasses may override if needed

            return _cake;
        }
    }

    /// <summary>
    /// Our subclasses, which can change the end behaviour of the parent skeleton method
    /// </summary>
    public class CarrotCakeCooker : CakeCooker
    {
        public CarrotCakeCooker(Cake cake) : base(cake) { }

        protected override void Bake() { }

        protected override void PrepareBatter()
        {
            _cake.SecretIngredient = "Carrots!";
        }
    }

    public class MudCakeCooker : CakeCooker
    {
        public MudCakeCooker(Cake cake) : base(cake) { }

        protected override void Bake() { }

        protected override void PrepareBatter()
        {
            _cake.SecretIngredient = "Mud!";
        }
    }
}