using System.Linq;
using System.Net.NetworkInformation;

namespace NetStateSpeed
{
    class CheckPacketDelay
    {
        private Ping checkPing = new Ping();

        public int CheckPing(string host) 
        {
            

            var arrPing = new int [10];

            for (int i = 0; i < 10; i++) 
            {
                arrPing[i] = (int)checkPing.Send(host, 1000).RoundtripTime;
            }

            return (int)arrPing.Average();

        }
        
    }
}
