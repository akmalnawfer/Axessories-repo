using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Enumerations
{
    public enum WatchBeltTypeEnum
    {
        [Description("Leather")]
        Leather = 1,
        [Description("Chain")]
        Chain,
        [Description("Rexin")]
        Rexin
    }
}
