using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeProject.OutlookNavi
{
    class SensorViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Sensor Page";
            }
        }
    }
}
