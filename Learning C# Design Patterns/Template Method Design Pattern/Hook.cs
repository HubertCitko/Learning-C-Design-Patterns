using static Template.Hook.Hook;

//new A().Start();

namespace Template.Hook
{
    public class Hook
    {
        public abstract class Process
        {
            public void Start()
            {
                AbstractHook();
                DefaultHook();
            }
            // Has to be implemented by subclasses
            public abstract void AbstractHook();

            // It can be overridden but does not have to be implemented by subclasses
            public virtual void DefaultHook() => Console.WriteLine("Default Hook Implementation");
        }

        public class A : Process
        {
            public override void DefaultHook() => Console.WriteLine("Class A Default Hook Implementation");
            public override void AbstractHook() => Console.WriteLine("A's Abstract Hook Implementation");
        }
    }
}