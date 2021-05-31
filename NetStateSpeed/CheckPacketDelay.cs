using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace NetStateSpeed
{
    class CheckPacketDelay
    {
        public int CheckPing(string host) 
        {
            
            var checkPing = new Ping();

            var arrPing = new int [10];

            for (int i = 0; i < 10; i++) 
            {
                arrPing[i] = (int)checkPing.Send(host, 1000).RoundtripTime;
            }

            return (int)arrPing.Average();

        }
        
    }
}
