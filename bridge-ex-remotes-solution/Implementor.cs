using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_ex_remotes_solution
{
    public interface IRemoteImplementor
    {
        void DoActivity(string activity);

        int Channel { get; set; }
        int Volume { get; set; }
    }

    public class LogitechImplementation : IRemoteImplementor
    {
        public void DoActivity(string activity)
        {
        }

        public int Channel
        {
            get;
            set;
        }

        public int Volume
        {
            get;
            set;
        }

    }
}
