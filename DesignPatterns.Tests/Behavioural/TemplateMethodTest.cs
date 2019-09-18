using System.Collections.Generic;
using Xunit;
using DesignPatterns.Behavioural.TemplateMethod;

namespace DesignPatterns.Tests.Behavioural
{
    public class TemplateMethodTest
    {   
        [Fact]
        public void TestCarrotCakeRecipe()
        {
            var blankCake = new CarrotCake();
            var cooker = new CarrotCakeCooker(blankCake);

            var finalResult = cooker.Cook();

            Assert.Equal("Carrots!", finalResult.SecretIngredient);
        }

        [Fact]
        public void TestMudCakeRecipe()
        {
            var blankCake = new MudCake();
            var cooker = new MudCakeCooker(blankCake);

            var finalResult = cooker.Cook();

            Assert.Equal("Mud!", finalResult.SecretIngredient);
        }
    }
}