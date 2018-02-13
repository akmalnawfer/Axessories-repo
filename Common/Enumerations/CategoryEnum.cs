using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Enumerations
{
    public enum CategoryEnum
    {
        [Description("Television")]
        TV = 1,
        [Description("Audio")]
        Audio,
        [Description("Smart Phone")]
        SmartPhones,
        [Description("Computer")]
        Computers,
        [Description("Watches")]
        Watches,
        [Description("Accessories")]
        Accessories
    }
}
