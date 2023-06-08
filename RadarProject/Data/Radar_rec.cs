using System;
using System.Collections.Generic;
using System.Net.Sockets;

public class Radar_rec
{
	public Radar_rec()
	{
	}
    public List<Drone> list_of_drones()
    {
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        // Connect to the server
        socket.Connect("ip_adress", 2303);

        byte[] buffer = new byte[8];

        List<Drone> Drone_list = new List<Drone>();

        while (socket.Receive(buffer) == buffer.Length)
        {
            Drone drone = new Drone();
            drone.degree = BitConverter.ToInt32(buffer, 0);
            drone.distance = BitConverter.ToInt32(buffer, 4);
            Drone_list.Add(drone);
        }
        return Pixel_list;
    }
}
