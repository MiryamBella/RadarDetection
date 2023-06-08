using System;
using System.Collections.Generic;

public class CLASSCALID
{
	public CLASSCALID()
	{
	}
	List<PlotRadar> blue_drones= new List<PlotRadar>
	public radar_and_picture(List<PlotRadar> radars, List<PlotPicture> picture)
	{
		foreach (drone in radars)
		{
			x_drone = drone.azimuth / (image_degree / image_size_x) +512;
			//bright?
			foreach(p in picture)
			{
				if (abs(x_drone - p) <= degree_error_threshold)//and bright?
				{
					blue_drones.Add(drone)
				}
			}
		}

	}

}
