using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp
{
    //enum is named series of related constants
    public enum OrderStatus : byte
    {
        Pending,
        InProcess,
        InTransit,
        Delivered,
        Cancelled
    }
}
