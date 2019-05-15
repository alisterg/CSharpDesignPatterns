using DesignPatterns.Creational.Singleton;
using Xunit;

namespace DesignPatterns.Tests.Creational
{
    public class SingletonTest
    {
        [Fact]
        public void TestSingletonIsSameInstance()
        {
            MainSingletonApp app = new MainSingletonApp();
            
            Assert.True(app.AreInstancesTheSame());
        }
    }
}