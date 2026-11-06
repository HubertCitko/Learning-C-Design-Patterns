namespace Template.Avoid
{
    public class Avoid
    {

        // Basic Example
        public class Process
        {
            public void Execute()
            {
                Step1();
                Step2();
                Step3();
            }
            public void Step1() => Console.WriteLine("Executing Step 1");
            public void Step2() => Console.WriteLine("Executing Step 2");
            public void Step3() => Console.WriteLine("Executing Step 3");
        }

        // More state == harder to understand and maintain
        public class Process_Configured
        {
            public void Execute(int a)
            {
                Step1();
                Step2();
                if (a == 0)
                {
                    Step3();
                }
                else
                {
                    Step4();
                }
            }
            public void Step1() => Console.WriteLine("Executing Step 1");
            public void Step2() => Console.WriteLine("Executing Step 2");
            public void Step3() => Console.WriteLine("Executing Step 3");
            public void Step4() => Console.WriteLine("Executing Step 4");
        }

        // Use the strategy to suply the algorith DO NOT vary the it
        public class Process_Strategy
        {
            Action strategy;
            public Process_Strategy(Action strategy)
            {
                this.strategy = strategy;
            }

            public void Execute()
            {
                Step1();
                Step2();
                strategy();
            }
            public void Step1() => Console.WriteLine("Executing Step 1");
            public void Step2() => Console.WriteLine("Executing Step 2");
        }
    }
}