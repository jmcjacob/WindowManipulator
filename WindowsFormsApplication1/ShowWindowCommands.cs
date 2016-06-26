using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowManipulator
{
    // Taken from http://www.pinvoke.net/default.aspx/user32.showwindow

    enum ShowWindowCommands
    {
        Hide = 0,
        Normal = 1,
        ShowMinimized = 2,
        Maximize = 3,      
        ShowMaximized = 3,
        ShowNoActivate = 4,
        Show = 5,
        Minimize = 6,
        ShowMinNoActive = 7,
        ShowNA = 8,
        Restore = 9,
        ShowDefault = 10,
        ForceMinimize = 11
    }
}
