using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Enumerations
{
    public enum AudioTypeEnum
    {
        [Description("Home Theater System")]
        HomeTheaterSystem = 1,
        [Description("Wireless")]
        Wireless,
        [Description("Stereo")]
        Stereo,
    }
}
