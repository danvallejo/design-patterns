using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_ex_remotes_solution
{
    // Create a new system (universal remote).
    // The abstraction is the remote.
    // The implementation would be the various kinds of remotes. 
    class Program
    {
        static void Main()
        {
            var remote = new LogitechRemote();
            remote.Implementor = new LogitechImplementation();

            remote.ChannelUp();
            remote.ChannelUp();
            int currentChannel = remote.CurrentChannel;

        }
    }
}
