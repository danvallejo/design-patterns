namespace proxy_ex_solution
{
    public interface IRemote
    {
        void ChangeChannel(int channel);
        int Volume { get; set; }
    }
}