using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Enumerations
{
    public enum SimSlotsEnum
    {
        [Description("Single Sim")]
        SingleSim = 1,
        [Description("Dual Sim")]
        DualSim
    }
}
