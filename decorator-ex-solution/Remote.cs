using System;

namespace decorator_ex_solution
{
    public interface IRemote
    {
        void ChangeChannel(int channel);
        int Volume { get; set; }
    }

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
