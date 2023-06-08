using System;
using radar_project;

namespace radar_project
{
    public static class Pixel
    {
        public static UInt32 x;
        public static UInt32 y;
        public static UInt32 bright;
        public static Pixel(UInt32 x_, UInt32 y_, UInt32 b)
        {
            x = x_;
            y = y_;
            bright = b;
        }
    }
}
