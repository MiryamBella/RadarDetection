using System;
using radar_project;

namespace radar_project
{
    public enum Color { white, blue, red }
    public class Drone
    {
        UInt32 degree;
        UInt32 distance;
        Color color;
        public PlotRadar(UInt32 deg, UInt32 dis)
        {
            degree = deg;
            distance = dis;
            color = Color.white;
        }
    }
}
