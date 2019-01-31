using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.Creational
{
    /// <summary>
    /// The Factory Method is a method that will create an object
    /// of a specific type or a specific state. This is useful to
    /// abstract functionality from creating a required object.
    /// </summary>


    abstract class Meal
    {
        protected Boolean _burger;
        protected Boolean _chips;

        // The factory method
        abstract Meal GetMeal();
    }

    class LargeMeal : Meal
    {
        public override Meal GetMeal()
        {
            _burger = true;
            _chips = true;

            return this;
        }
    }

    class SmallMeal : Meal
    {
        public override Meal GetMeal()
        {
            _burger = true;
            _chips = false;

            return this;
        }
    }

    class MealOrderer
    {
        public Meal OrderSmallMeal()
        {
            SmallMeal meal = new SmallMeal();

            return meal.GetMeal();
        }

        public Meal OrderLargeMeal()
        {
            LargeMeal meal = new LargeMeal();

            return meal.GetMeal();
        }
    }
}