namespace factory_ex_solution
{
    public class Document
    {
        public string Name { get; set; }
        public string Contents { get; set; }
    }

    public class WordDocument : Document
    {
        public string Subject { get; set; }
    }

    public class ExcelDocument : Document
    {
        public string Formula { get; set; }
    }
}
