using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoISI.Entities;

namespace TrabalhoISI.Entities.Enums
{
    internal enum OrderStatus : int
    {
        Pending = 0,
        Preparing = 1,
        Served = 2
    }
}
