using System;
using radar_project;

namespace radar_project
{
    public class Pixel
    {
        public UInt32 x;
        public UInt32 y;
        public UInt32 bright;
        public Pixel(UInt32 x_, UInt32 y_, UInt32 b)
        {
            x = x_;
            y = y_;
            bright = b;
        }
    }
}
