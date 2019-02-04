using System;

namespace CSharpDesignPatterns.Creational
{
    /// <summary>
    /// The Builder pattern is a pattern to build objects, bit by bit,
    /// until you have the object you require. In contrast with the
    /// Factory, this will allow the programmer to create a tailored
    /// object.
    /// 
    /// TODO: create the builders
    /// </summary>

    class MainApp
    {
        public void Main()
        {
            // We can build the object to specification
            Cat myCat = new Tiger()
                .WithClaws()
                .WithTeeth();

            myCat.Pounce();
        }
    }

    abstract class Cat
    {
        protected String _teeth;
        protected String _claws;

        abstract Cat WithTeeth();
        abstract Cat WithClaws();
        abstract void Pounce();
    }

    class Tiger : Cat
    {
        /// <returns>
        /// We can return 'this' to create a fluent interface via 
        /// method chaining.
        /// </returns>
        public override Cat WithTeeth()
        {
            _teeth = "Sharp";

            return this;
        }

        public override Cat WithClaws()
        {
            _claws = "Sharp";

            return this;
        }

        public override void Pounce()
        {
            //
        }
    }

}