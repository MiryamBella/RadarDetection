using Microsoft.VisualBasic;

namespace RadarProject
{
    public class MainProcessing
    {

        public Conversion convert;
        public List<PlotRadar> DroneRadars;
        public List<PlotPicture> PlotLaser;

        public MainProcessing()
        {
            DroneRadars = new List<PlotRadar>();
            PlotLaser = new List<PlotPicture>();


        }


        public EnterData(string binaryRadar, string binaryLaser)
        {
            DroneRadars = convert.Conver2data_radar(binaryRadar);
            PlotLaser = convert.Conver2data_laser(binaryLaser);
        }


    }
}