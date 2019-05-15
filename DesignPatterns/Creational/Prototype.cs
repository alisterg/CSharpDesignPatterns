using System;

namespace DesignPatterns.Creational.Prototype
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
    /// </summary>
    
    public class MainPrototypeApp
    {
        public CarrotCakePrototype GetPrototype1()
        {
            CarrotCakePrototype carrotCake = new CarrotCakePrototype();
            carrotCake.SecretIngredient = "carrot";
            return carrotCake;
        }

        public CarrotCakePrototype GetPrototype2(CarrotCakePrototype prototype1)
        {
            CarrotCakePrototype newCarrotCake = (CarrotCakePrototype)prototype1.Clone();
            return newCarrotCake;
            
            // now we have two delicious carrot cakes, without having to
            // initialise / perform operations on two instances.
        }
    }

    public interface IPrototype
    {
        // we could make this abstract class and define other members
        // in the prototype 

        IPrototype Clone();
    }

    public class CarrotCakePrototype : IPrototype
    {
        public string SecretIngredient { get; set; }
        
        public IPrototype Clone() 
        {
            // now we have a copy of the object
            return (CarrotCakePrototype)this.MemberwiseClone();
        }
    }

    public class MudCakePrototype : IPrototype
    {
        public IPrototype Clone() 
        {
            return (MudCakePrototype)this.MemberwiseClone();
        }
    }
}