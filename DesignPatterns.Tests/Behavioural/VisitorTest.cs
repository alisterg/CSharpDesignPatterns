using System.Collections.Generic;
using Xunit;
using DesignPatterns.Behavioural.Visitor;

namespace DesignPatterns.Tests.Creational
{
    public class VisitorTest
    {
        private ICakeVisitor _cakeVisitor;
        
        public VisitorTest()
        {
            _cakeVisitor = new CakeVisitor();
        }
        
        [Fact]
        public void TestCarrotCakeHadIcingAdded()
        {
            CarrotCake carrotCake = new CarrotCake();
            
            carrotCake.Accept(_cakeVisitor); // throws
            
            Assert.Equal("Vanilla Icing", carrotCake.Icing);
            Assert.False(carrotCake.DoubleIcing);
        }

        [Fact]
        public void TestMudCakeHadIcingAdded()
        {
            MudCake mudCake = new MudCake();
            
            mudCake.Accept(_cakeVisitor);
            
            Assert.Equal("Chocolate Icing", mudCake.Icing);
            Assert.True(mudCake.DoubleIcing);
        }

        [Fact]
        public void TestAllCakesGotIcingAdded()
        {
            List<IVisitableCake> visitableCakes = new List<IVisitableCake>()
            {
                new MudCake(),
                new CarrotCake()
            };
            
            CakeIcer cakeIcer = new CakeIcer(visitableCakes);

            List<IVisitableCake> icedCakes = cakeIcer.PutIcingOnCakes();
            
            Assert.Equal("Chocolate Icing", icedCakes[0].Icing);
            Assert.Equal("Vanilla Icing", icedCakes[1].Icing);
            Assert.True(icedCakes[0].DoubleIcing);
            Assert.False(icedCakes[1].DoubleIcing);
        }
    }
}