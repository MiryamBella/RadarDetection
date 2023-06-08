using System;
using radar_project;

namespace radar_project
{
    public enum Color { white, blue, red }
    public class Drone
    {
        public UInt32 degree;
        public UInt32 distance;
        public Color color;
        public Drone(UInt32 deg, UInt32 dis)
        {
            degree = deg;
            distance = dis;
            color = Color.white;
        }
    }
}
