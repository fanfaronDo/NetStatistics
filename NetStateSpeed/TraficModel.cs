using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStateSpeed
{
    class TraficModel
    {
        
        public double bytesSentSpeedPrev = 0;
        public double bytesReceivedSpeedPrev = 0;

        public double bytesSentSpeedCurrent = 0;
        public double bytesReceivedSpeedCurrent = 0;

        public double bytesReceived = 0;

        public double bytesSent = 0;

        public List<double> MeasurementsSpeedSent = new List<double>();

        public List<double> MeasurementsSpeedReceived = new List<double>();

        public double MeasurementsSpeedAvgSent = 0;

        public double MeasurementsSpeedAvgReceived = 0;

        public int SpeedInterface = 0;

        public string nameInterface = "";

        public double downloadBytes = 0;

        public double uploadBytes = 0;

        public double downloadSpeedPrev = 0;
        public double downloadSpeedCur = 0;

        public double uploadSpeedPrev = 0;
        public double uploadSpeedCur = 0;

        public double resultDownload = 0;

        public bool controller = false;
    }
}
