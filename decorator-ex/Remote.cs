using System;

namespace decorator_ex
{
    public class Remote
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
