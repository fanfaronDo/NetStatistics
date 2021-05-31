using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStateSpeed
{
    class BandwidthCalculation
    {
        
        public double GetDownloadSpeed(TraficModel trafic)
        {
            var tasks = FormattingAddress.GetSpeedBytesDown(new Producer().urlProduserServer);

            trafic.downloadSpeedPrev = trafic.bytesReceived;

            var stopwatch = Stopwatch.StartNew();
            Task.WaitAll(tasks.ToArray());
            stopwatch.Stop();

            trafic.downloadSpeedCur = trafic.bytesReceived;

            var time = stopwatch.ElapsedMilliseconds / 1000.0;

            var rez = trafic.downloadSpeedCur - trafic.downloadSpeedPrev;

            return (rez / time);

            
        }
        public double GetUploadSpeed(TraficModel trafic)
        {
            var tasks = FormattingAddress.GetSpeedBytesUp(new Producer().urlProduserServer);

            trafic.uploadSpeedPrev = trafic.bytesSent;

            var stopwatch = Stopwatch.StartNew();
            Task.WaitAll(tasks.ToArray());
            stopwatch.Stop();

            var time = stopwatch.ElapsedMilliseconds / 1000.0;

            trafic.uploadSpeedCur = trafic.bytesSent;

            var rez = trafic.uploadSpeedCur - trafic.uploadSpeedPrev;

            return (rez / time);

            
        }




    }
}
