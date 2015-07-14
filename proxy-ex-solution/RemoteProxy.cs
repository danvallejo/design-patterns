using System;

namespace proxy_ex_solution
{
    class RemoteProxy : IRemote
    {
        private Remote remote = new Remote();

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
