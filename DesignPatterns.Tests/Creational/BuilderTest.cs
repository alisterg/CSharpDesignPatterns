using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using Xunit;

namespace DesignPatterns.Tests.Creational
{
    public class BuilderTest
    {
        private readonly Cake _myCake;
        
        public BuilderTest()
        {
            var builderApp = new MainBuilderApp();
            _myCake = builderApp.Main();
        }
        
        [Fact]
        public void TestGotCorrectCake()
        {
            Assert.Equal("carrot", _myCake.SecretIngredient);
        }
    }
}