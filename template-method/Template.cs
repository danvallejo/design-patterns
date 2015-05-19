using System;

namespace template_method
{
    abstract public class Template
    {
        public abstract void StepOne();
        public abstract void StepTwo();

        public virtual void StepThree()
        {
            Console.WriteLine("Default Step Three");
        }

        public void TemplateMethod()
        {
            StepOne();
            StepTwo();
            StepThree();
        }
    }

    public class ConcreteClass : Template
    {
        public override void StepOne()
        {
            Console.WriteLine("Step One");
        }

        public override void StepTwo()
        {
            Console.WriteLine("Step Two");
        }

        public override void StepThree()
        {
            Console.WriteLine("Step Three");
        }
    }
}
