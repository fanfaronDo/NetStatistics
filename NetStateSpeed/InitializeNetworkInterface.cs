using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetStateSpeed
{
    class InitializeNetworkInterface
    {
        public static NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();


        //Вложить имена всех интерфейсов в лист элемента ComboBox
        public void InitializAllInterface(ComboBox cmbInterface) 
        {
            

            for (int i = 0; i < networkInterfaces.Length; i++) 
            {
                cmbInterface.Items.Add(networkInterfaces[i].Name);
            }

            cmbInterface.SelectedIndex = 0;
        }

        


    }
}
