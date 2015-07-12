using System;

namespace proxy_ex_solution
{
    public class Remote : IRemote
    {
        public void ChangeChannel(int channel)
        {
        }

        private int volume;

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (volume < 0 || volume > 100)
                {
                    throw new ArgumentOutOfRangeException("Volume");
                }

                volume = value;
            }
        }
    }
}
