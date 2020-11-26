using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Grade_Report
{
    interface IModule
    {
        string Module { get; set; }
        double Weight { get; set; }
    }
}
