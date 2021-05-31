using System.Net.NetworkInformation;
using System.Windows.Forms;


namespace NetStateSpeed
{
    class GetValueNetworkInterface : InitializeNetworkInterface 
    {
        

        public void UpdateNetworkInterface(ComboBox cmbInterface, TraficModel trafic)
        {
           
          
            // Захватить объект NetworkInterface, который описывает текущий интерфейс

            NetworkInterface nic = networkInterfaces[cmbInterface.SelectedIndex];

            // Получить статистику для интерфейса

            IPv4InterfaceStatistics interfaceStats = nic.GetIPv4Statistics();

            var tempReceived = (double)interfaceStats.BytesReceived;
            var tempSent = (double)interfaceStats.BytesSent;

            trafic.bytesReceived = tempReceived;
            trafic.bytesSent = tempSent;


            double tempReceived1 = 0;
            
            trafic.bytesReceivedSpeedCurrent = tempReceived - trafic.bytesReceivedSpeedPrev;
            tempReceived1 = tempReceived;
            trafic.bytesReceivedSpeedPrev = tempReceived1;


            double tempSent1 = 0;

            trafic.bytesSentSpeedCurrent = tempSent - trafic.bytesSentSpeedPrev;
            tempSent1 = tempSent;
            trafic.bytesSentSpeedPrev = tempSent1;


            trafic.bytesSentSpeedPrev = tempSent;

            int speedInterface = (int)(nic.Speed / 1000000);

            trafic.nameInterface = nic.NetworkInterfaceType.ToString();

            trafic.SpeedInterface = speedInterface;

            trafic.bytesReceived = tempReceived;

            trafic.bytesSent = tempSent;

          
            
        }
       
        
    }
}
