﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTViewClient.PTView.Driver.Internal
{
    public static class Constants
    {
        public static readonly uint IOCTL_UNLOAD = CTL_CODE(0x8000, 0x800, METHOD_NEITHER, 0);

        private const uint METHOD_NEITHER = 3;

        private static uint CTL_CODE(uint deviceType, uint function, uint method, uint access)
        {
            return ((deviceType) << 16) | ((access) << 14) | ((function) << 2) | (method);
        }
    }
}