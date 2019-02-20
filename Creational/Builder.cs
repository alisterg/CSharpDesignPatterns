using System;

namespace CSharpDesignPatterns.Creational
{
    /// <summary>
    /// The Builder pattern is a pattern to build objects, bit by bit,
    /// until you have the object you require. Similarly to the Factory,
    /// this will produce a ready-made object; the main difference is that
    /// the Builder will produce the object over a series of steps.
    /// 
    /// TODO test this
    /// </summary>

    class MainApp
    {
        public void Main()
        {
            Cake myCarrotCake;
            CakeShop shop = new CakeShop();

            CarrotCakeBuilder builder = new CarrotCakeBuilder();

            myCarrotCake = shop.MakeCake(builder);

            // can now eat the delicious cake :)
        }
    }

    class CakeShop
    {
        public void MakeCake(CakeBuilder builder)
        {
            builder.WithFlour()
                .WithSecretIngredient();

            return builder.Build();
        }
    }

    interface CakeBuilder
    {
        protected Cake MyCake { get; }

        abstract CakeBuilder WithFlour();
        abstract CakeBuilder WithSecretIngredient();
        abstract Cake Build();
    }

    class CarrotCakeBuilder : CakeBuilder
    {
        public CarrotCakeBuilder()
        {
            MyCake = new Cake();
        }

        /// <returns>
        /// We can return 'this' to create a fluent interface via 
        /// method chaining.
        /// </returns>
        public override CakeBuilder WithFlour()
        {
            MyCake.AddFlour();

            return this;
        }

        public override CakeBuilder WithSecretIngredient()
        {
            MyCake.AddFlour("carrot");

            return this;
        }

        public override Cake Build()
        {
            return MyCake;
        }
    }

    class Cake
    {
        private bool _flour;
        private String _secretIngredient;

        public void AddFlour()
        {
            _flour = true;
        }

        public void AddSecretIngredient(String ingredient)
        {
            _secretIngredient = ingredient;
        }
    }

}