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
            CreateMatrix();
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
                Fill = Brushes.White,
                Stroke = Brushes.Black,
                StrokeThickness = 1,
                Margin = new Thickness(x - 3, y - 3, 0, 0) // Adjust position based on size of ellipse
            };

            coordinateSystem1.Children.Add(point);
        }
        
        public void EnterPoints(List<Drone> drones)
        {
            foreach( Drone drone in drones)
            {
                AddDrone1(drone);
            }


        }


        public void AddDrone1(Drone drone)
        {
            ///lnermak
            ///
            AddPointAtPolarCoordinates(drone.degree, drone.distance);

        }



        private void CreateMatrix()
        {
            const int Rows = 3;
            const int Columns = 3;
            MatrixGrid.Children.Clear();
            MatrixGrid.RowDefinitions.Clear();
            MatrixGrid.ColumnDefinitions.Clear();

            for (int i = 0; i < Rows; i++)
            {
                MatrixGrid.RowDefinitions.Add(new RowDefinition());

                for (int j = 0; j < Columns; j++)
                {
                    MatrixGrid.ColumnDefinitions.Add(new ColumnDefinition());

                    Border square = new Border
                    {
                        BorderBrush = Brushes.Black,
                        BorderThickness = new Thickness(1),
                        Background = Brushes.White
                    };

                    Grid.SetRow(square, i);
                    Grid.SetColumn(square, j);

                    MatrixGrid.Children.Add(square);
                }
            }
        }

    }



    public class Drone
    {
        public double degree { get; set; }
        public double distance { get; set; }
    }

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


