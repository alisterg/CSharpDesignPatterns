using System;

namespace CSharpDesignPatterns.Creational
{
    /// <summary>
    /// The Prototype pattern basically clones objects instead of
    /// creating new ones.
    /// 
    /// Fun fact: Javascript's OOP model is built upon prototypal inheritance.
    /// Every object in Javascript is created by creating a new instance
    /// of a prototype which inherited from the Object prototype. Even
    /// classes in ES6 are just syntactic sugar upon functionality which
    /// creates a new prototype.
    /// 
    /// TODO test
    /// </summary>
    
    class Main
    {
        public void Run() 
        {
            CarrotCakePrototype carrotCake = new CarrotCakePrototype();
            CarrotCakePrototype newCarrotCake = carrotCake.Clone();

            // now we have two delicious carrot cakes, without having to
            // initialise / perform operations on two instances.
        }
    }

    interface Prototype
    {
        // we could make this abstract class and define other members
        // in the prototype 

        Prototype Clone();
    }

    class CarrotCakePrototype : Prototype
    {
        public Prototype Clone() 
        {
            // now we have a copy of the object
            return (CarrotCakePrototype) this.MemberwiseClone();
        }
    }

    class MudCakePrototype : Prototype
    {
        public Prototype Clone() 
        {
            return (MudCakePrototype) this.MemberwiseClone();
        }
    }
}