namespace visitor_ex_solution
{
    public abstract class FileSystemElement
    {
        public string FileName { get; set; }
        public abstract void Accept(IVisitor visitor);
    }

    public class FileElement : FileSystemElement
    {
        public FileElement(string fileName)
        {
            FileName = fileName;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
