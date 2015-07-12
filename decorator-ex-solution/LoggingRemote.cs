using System;

namespace decorator_ex_solution
{
    public class LoggingRemote : IRemote
    {
        private readonly IRemote remote;

        public LoggingRemote(IRemote remote)
        {
            this.remote = remote;
        }

        public void ChangeChannel(int channel)
        {
            Console.WriteLine("Changing channel to {0}", channel);
            remote.ChangeChannel(channel);
        }

        public int Volume
        {
            get
            {
                Console.WriteLine("Getting volume {0}", remote.Volume);
                return remote.Volume;
            }
            set
            {
                Console.WriteLine("Setting volume {0}", value);
                remote.Volume = value;
            }
        }
    }
}
