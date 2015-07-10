using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_ex_remotes_solution
{
    public interface IRemote
    {
        IRemoteImplementor Implementor { get; set; }
        void DoActivity(string activity);

        void ChangeChannel(int channel);
        int CurrentChannel { get; }

        void ChannelUp();
        void ChannelDown();

        void VolumeUp();
        void VolumeDown();
    }

    public class LogitechRemote : IRemote
    {
        public void DoActivity(string activity)
        {
            Implementor.DoActivity(activity);
        }

        public void ChangeChannel(int channel)
        {
            Implementor.Channel = channel;
        }

        public void ChannelUp()
        {
            Implementor.Channel++;
        }

        public void ChannelDown()
        {
            Implementor.Channel--;
        }

        public void VolumeUp()
        {
            Implementor.Volume++;
        }

        public void VolumeDown()
        {
            Implementor.Volume--;
        }

        public IRemoteImplementor Implementor
        {
            get;
            set;
        }


        public int CurrentChannel
        {
            get
            {
                return Implementor.Channel;
            }
        }
    }
}
