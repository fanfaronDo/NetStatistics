using System;
using System.Windows.Forms;

namespace NetStateSpeed
{
    class DataTranslation
    {
        public double ValueTranslate(ComboBox combobox, double data) 
        {
            
            switch (combobox.SelectedIndex) 
            {
                case 0:
                    return Math.Round(data / 1000 * 8, 2);
                case 1:
                    return Math.Round(data / 1000 / 1000 * 8, 2);
                case 2:
                    return Math.Round(data / 1000, 2);
                case 3:
                    return Math.Round(data / 1000 / 1000, 2);
                default:
                    return Math.Round(data, 2);
            }

                
        }

      
    }
}
