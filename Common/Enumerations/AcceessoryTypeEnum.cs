using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Enumerations
{
    public enum AcceessoryTypeEnum
    {
        [Description("Phone Cover")]
        PhoneCover = 1,
        [Description("Headphones")]
        HeadPhones,
        [Description("Charger")]
        Charger,
        [Description("USB Cable")]
        USBCable,
        [Description("Power Bank")]
        PowerBank,
        [Description("Selfi Stick")]
        SelfieStick,
        [Description("Screen Protector")]
        ScreenProtector,
        [Description("Other")]
        Other
    }
}
