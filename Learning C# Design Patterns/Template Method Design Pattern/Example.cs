using static Template.Example.TemplateExample;
/*
new Process().Execute();
Console.WriteLine("---");
new ProcesVariationA().Execute();
Console.WriteLine("---");
new ProcessVariationB().Execute();
Console.WriteLine("---");
new ProcessVariationC().Execute();
*/
namespace Template.Example
{

    public class TemplateExample
    {
        public class Process
        {
            public void Execute()
            {
                Step1();
                Step2();
                Step3();
            }
            protected virtual void Step1() => Console.WriteLine("Executing Step 1");
            protected virtual void Step2() => Console.WriteLine("Executing Step 2");
            protected virtual void Step3() => Console.WriteLine("Executing Step 3");
        }

        public class ProcesVariationA : Process
        {
            protected override void Step2() => Console.WriteLine("Executing Step 2 - Variation A");
        }

        public class ProcessVariationB : Process
        {
            protected override void Step3() => Console.WriteLine("Executing Step 3 - Variation B");
        }

        public class ProcessVariationC : Process
        {
            protected override void Step1() => Console.WriteLine("Executing Step 1 - Variation C");
            protected override void Step2() => Console.WriteLine("Executing Step 2 - Variation C");
            protected override void Step3() => Console.WriteLine("Executing Step 3 - Variation C");
        }
    }

    
}
