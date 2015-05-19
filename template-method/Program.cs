namespace template_method
{
    class Program
    {
        static void Main()
        {
            var template = new ConcreteClass();

            template.TemplateMethod();
        }
    }
}
