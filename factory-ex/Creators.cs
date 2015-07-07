namespace factory_ex
{
    public static class Creators
    {
        public static WordDocument CreateWordDocument(string name)
        {
            return new WordDocument {Name = name};
        }

        public static ExcelDocument CreateExcelDocument(string name)
        {
            return new ExcelDocument { Name = name };
        }
    }
}
