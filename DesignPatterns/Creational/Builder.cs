using System;

namespace DesignPatterns.Creational.Builder
{
    /// <summary>
    /// The Builder pattern is a pattern to build objects, bit by bit,
    /// until you have the object you require. Similarly to the Factory,
    /// this will produce a ready-made object; the main difference is that
    /// the Builder will produce the object over a series of steps.
    /// 
    /// TODO test
    /// </summary>

    class MainBuilderApp
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
        public Cake MakeCake(CakeBuilder builder)
        {
            builder.WithFlour()
                .WithSecretIngredient();

            return builder.Build();
        }
    }

    interface CakeBuilder
    {
        Cake MyCake { get; }

        CakeBuilder WithFlour();
        CakeBuilder WithSecretIngredient();
        Cake Build();
    }

    class CarrotCakeBuilder : CakeBuilder
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
        public CakeBuilder WithFlour()
        {
            MyCake.AddFlour();

            return this;
        }

        public CakeBuilder WithSecretIngredient()
        {
            MyCake.AddSecretIngredient("carrot");

            return this;
        }

        public Cake Build()
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