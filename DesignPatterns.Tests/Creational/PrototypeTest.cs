using DesignPatterns.Creational.Prototype;
using Xunit;

namespace DesignPatterns.Tests.Creational
{
    public class PrototypeTest
    {
        [Fact]
        public void TestPrototypeWorks()
        {
            MainPrototypeApp prototypeApp = new MainPrototypeApp();

            var prot1 = prototypeApp.GetPrototype1();

            Assert.IsType<CarrotCakePrototype>(prot1);

            var prot2 = prototypeApp.GetPrototype2(prot1);

            Assert.IsType<CarrotCakePrototype>(prot2);
            
            Assert.Equal(prot1.SecretIngredient, prot2.SecretIngredient);
        }
    }
}