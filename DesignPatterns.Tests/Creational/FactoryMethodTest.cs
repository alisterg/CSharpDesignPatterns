using DesignPatterns.Creational.FactoryMethod;
using Xunit;

namespace DesignPatterns.Tests.Creational
{
    public class FactoryMethodTest
    {
        private readonly ICake _myCake;
        
        public FactoryMethodTest()
        {
            var factoryApp = new MainFactoryApp();
            _myCake = factoryApp.Main();
        }
        
        [Fact]
        public void TestGotCorrectCake()
        {
            Assert.IsType<CarrotCake>(_myCake);
        }

        [Fact]
        public void TestCakeWorks()
        {
            Assert.Equal("Baking carrot cake!", _myCake.BakeTime());
        }
    }
}
