using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioural.Visitor
{
    /// <summary>
    /// The Visitor pattern is used to perform actions on collections of common types.
    /// We define an interface that has a Visit method for each concrete type we want to
    /// be able to visit; and in our Visitable classes we define an Accept(IVisitor visitor) method,
    /// which simply calls visitor.Visit(this).
    /// The nature of the Visitor pattern enforces the Open/Closed Principle. We are extending
    /// the functionality of our Visitable classes without changing the class itself - we only
    /// have to change the Visitor class.
    /// A disadvantage of this pattern is that our Visitable classes are required to implement
    /// the Accept method, coupling these classes with the IVisitable interface.
    /// </summary>
    public class MainVisitorApp
    {
        public void Run()
        {
            List<IVisitableCake> cakesToIce = new List<IVisitableCake>()
            {
                new CarrotCake(),
                new MudCake()
            };
            
            CakeIcer cakeIcer = new CakeIcer(cakesToIce);

            var icedCakes = cakeIcer.PutIcingOnCakes();
            
            // now our cakes have delicious icing on them!
        }
    }

    /// <summary>
    /// The implementing class.
    /// </summary>
    public class CakeIcer
    {
        private List<IVisitableCake> _cakes;

        public CakeIcer(List<IVisitableCake> cakes)
        {
            _cakes = cakes;
        }

        public List<IVisitableCake> PutIcingOnCakes()
        {
            ICakeVisitor cakeVisitor = new CakeVisitor();

            foreach (IVisitableCake cake in _cakes)
            {
                cake.Accept(cakeVisitor);
            }

            return _cakes;
        }
    }
    
    /// <summary>
    /// Our visitable 'Elements' that we can visit
    /// </summary>
    public interface IVisitableCake
    {
        string Icing { get; set; }
        bool DoubleIcing { get; set; }

        void Accept(ICakeVisitor visitor);
    }

    /// <summary>
    /// Our visitor, which has different visit methods for 
    /// our different element types
    /// </summary>
    public interface ICakeVisitor
    {
        void Visit(CarrotCake element);
        void Visit(MudCake element);
    }

    /// <summary>
    /// Our concrete Visitor which is used to apply icing to our cakes.
    /// In our implementations, we can perform different actions on different elements. 
    /// </summary>
    public class CakeVisitor : ICakeVisitor
    {
        public void Visit(CarrotCake carrotVisitableCake)
        {
            carrotVisitableCake.Icing = "Vanilla Icing";
        }

        public void Visit(MudCake mudVisitableCake)
        {
            mudVisitableCake.Icing = "Chocolate Icing";
            mudVisitableCake.DoubleIcing = true;
        }
    }

    /// <summary>
    /// One of the concrete elements to 'visit'
    /// </summary>
    public class CarrotCake : IVisitableCake
    {
        public string Icing { get; set; }
        public bool DoubleIcing { get; set; } = false;
        
        public void Accept(ICakeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class MudCake : IVisitableCake
    {
        public string Icing { get; set; }
        public bool DoubleIcing { get; set; }

        public void Accept(ICakeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}