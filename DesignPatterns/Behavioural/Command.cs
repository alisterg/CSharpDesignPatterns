using System.Collections.Generic;

namespace DesignPatterns.Behavioural.Command
{
    /// <summary>
    /// The Command pattern is comprised of three main participants:
    /// The Command class, which is used to execute commands; the 
    /// Invoker class, which is used to invoke the Command class objects;
    /// and the Receiver class, which is passed into the concrete Command
    /// objects to perform specific actions.
    /// </summary>
    public class MainCommandApp
    {
        public void Run()
        {
            
        }
    }

    public interface ICommand
    {
        void Execute();
    }

    /// <summary>
    /// An interface for our Receiver class(es); the objects to apply
    /// our actions to
    /// </summary>
    public interface ICakeWithIcing
    {
        void AddIcing();
        void RemoveIcing();
    }

    /// <summary>
    /// Our Invoker class; used to run the commands
    /// </summary>
    public class CakeIcingInvoker
    {
        
    }

    /// <summary>
    /// A concrete Command class; Execute will apply icing to our cake
    /// </summary>
    public class CakeIcer : ICommand
    {
        public void Execute() {

        }
    }

    /// <summary>
    /// A concrete Command class; Execute will remove icing from our cake
    /// </summary>
    public class CakeUnIcer : ICommand
    {
        public void Execute() {

        }
    }
}