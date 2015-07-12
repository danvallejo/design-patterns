namespace chain_of_responsibility_ex_solution
{
    public class Message
    {
        public CommandType CommandType { get; set; }
        public string[] Arguments { get; set; }
    }
}