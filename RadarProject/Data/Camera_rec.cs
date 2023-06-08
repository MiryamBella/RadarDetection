using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using radar_project;
using Pixel;

namespace radar_project
{
    public class Camera_rec
    {
        public Camera_rec()
        {

        }
        public List<Pixel> list_of_pixels()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // Connect to the server
            socket.Connect("ip_adress", 2303);

            byte[] buffer = new byte[12];

            List<Pixel> Pixel_list = new List<Pixel>();

            while (socket.Receive(buffer) == buffer.Length)
            {
                Pixel pixel = new Pixel();
                pixel.x = BitConverter.ToInt32(buffer, 0);
                pixel.y = BitConverter.ToInt32(buffer, 4);
                pixel.bright = BitConverter.ToInt32(buffer, 8);
                Pixel_list.Add(pixel);
            }
            return Pixel_list;
        }
    }
}