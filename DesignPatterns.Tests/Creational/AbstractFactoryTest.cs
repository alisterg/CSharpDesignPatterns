using DesignPatterns.Creational.AbstractFactory;
using Xunit;

namespace DesignPatterns.Tests.Creational
{
    public class AbstractFactoryTest
    {
        private readonly CarrotCake _myCake;
        
        public AbstractFactoryTest()
        {
            var factoryApp = new MainAbstractFactoryApp();
            _myCake = factoryApp.Main(new []{"fancy"});
        }
        
        [Fact]
        public void TestGotCorrectCake()
        {
            Assert.IsType<FancyCarrotCake>(_myCake);
        }

        [Fact]
        public void TestCakeWorks()
        {
            Assert.Equal("Baking fancy carrot cake!", _myCake.BakeTime());
        }
    }
}