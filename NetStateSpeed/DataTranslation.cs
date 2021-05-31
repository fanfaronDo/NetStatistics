using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetStateSpeed
{
    class DataTranslation
    {
        public string ValueTranslate(ComboBox combobox, double data) 
        {
            

            switch (combobox.SelectedIndex) 
            {
                case 0:
                    return Math.Round(data / 1000 * 8, 2)+ " Kb/s".ToString();
                case 1:
                    return Math.Round(data / 1000 / 1000 * 8, 2) + " Mb/s".ToString();
                case 2:
                    return Math.Round(data / 1000, 2) + " KB/s".ToString();
                case 3:
                    return Math.Round(data / 1000 / 1000, 2) + " MB/s".ToString();
                default:
                    return Math.Round(data, 2)+ " B/s".ToString();
            }

                
        }

      
    }
}
