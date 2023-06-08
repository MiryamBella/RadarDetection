using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Data;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*
            //AddPointAtPolarCoordinates(90, 200);
            List<Drone> drones = new List<Drone>();
            for (int i =0; i<10; i++) {

                drones.Add(); 
            }
            EnterPoints();
            */
            AddPointAtPolarCoordinates(90, 300);
        }


        private void AddPointAtPolarCoordinates(double angle, double radius)
        {
            double centerX = xAxis.X1;
            double centerY = yAxis.Y1;

            double radians = angle * Math.PI / 180;
            double x = centerX + radius * Math.Cos(radians);
            double y = centerY - radius * Math.Sin(radians); // Negative sign for Y-coordinate due to flipped coordinate system

            Ellipse point = new Ellipse
            {
                Width = 6,
                Height = 6,
                Fill = Brushes.Red,
                Stroke = Brushes.Red,
                StrokeThickness = 1,
                Margin = new Thickness(x - 3, y - 3, 0, 0) // Adjust position based on size of ellipse
            };

            coordinateSystem1.Children.Add(point);
        }
        
        public void EnterPoints(List<Drone> drones)
        {
            foreach( Drone drone in drones)
            {
                //AddDrone1(drone.degree, drone.distance);
            }


        }


        public void AddDrone1(Drone drone)
        {
            ///lnermak
            ///
            AddPointAtPolarCoordinates(drone.zvit, drone.radius);

        }

    }



    public class Drone
    {
        public double zvit { get; set; }
        public double radius { get; set; }
    }

    

}


