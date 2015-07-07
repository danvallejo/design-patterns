namespace factory_ex_solution
{
    public abstract class DocumentFactory
    {
        public abstract Document Create(string name);
    }

    public class WordFactory : DocumentFactory
    {
        public override Document Create(string name)
        {
            return new WordDocument { Name = name };
        }
    }

    public class ExcelFactory : DocumentFactory
    {
        public override Document Create(string name)
        {
            return new ExcelDocument { Name = name };
        }
    }
}
