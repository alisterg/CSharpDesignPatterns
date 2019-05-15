using System;

namespace DesignPatterns.Creational.Builder
{
    /// <summary>
    /// The Builder pattern is a pattern to build objects, bit by bit,
    /// until you have the object you require. Similarly to the Factory,
    /// this will produce a ready-made object; the main difference is that
    /// the Builder will produce the object over a series of steps.
    /// </summary>

    public class MainBuilderApp
    {
        public Cake Main()
        {
            // Our 'director' - will direct the builder object how to build
            CakeShop shop = new CakeShop();
            // Our 'builder' - will follow the instructions of the 'director'
            CarrotCakeBuilder builder = new CarrotCakeBuilder();
            
            Cake myCarrotCake = shop.MakeCake(builder);

            // Our cake has been built to the specification from the builder
            return myCarrotCake;
            // can now eat the delicious cake :)
        }
    }

    public class CakeShop
    {
        public Cake MakeCake(ICakeBuilder builder)
        {
            builder.WithFlour()
                .WithSecretIngredient();

            return builder.Build();
        }
    }

    public interface ICakeBuilder
    {
        Cake MyCake { get; }

        ICakeBuilder WithFlour();
        ICakeBuilder WithSecretIngredient();
        Cake Build();
    }

    public class CarrotCakeBuilder : ICakeBuilder
    {
        public Cake MyCake { get; }

        public CarrotCakeBuilder()
        {
            MyCake = new Cake();
        }

        /// <returns>
        /// We can return 'this' to create a fluent interface via 
        /// method chaining.
        /// </returns>
        public ICakeBuilder WithFlour()
        {
            MyCake.AddFlour();

            return this;
        }

        public ICakeBuilder WithSecretIngredient()
        {
            MyCake.AddSecretIngredient("carrot");

            return this;
        }

        public Cake Build()
        {
            return MyCake;
        }
    }

    public class Cake
    {
        private bool _flour;
        private string _secretIngredient;
        
        public string SecretIngredient => _secretIngredient;

        public void AddFlour()
        {
            _flour = true;
        }

        public void AddSecretIngredient(string ingredient)
        {
            _secretIngredient = ingredient;
        }
    }

}