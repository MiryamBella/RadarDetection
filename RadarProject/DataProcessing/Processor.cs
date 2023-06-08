using System;
using System.Collections.Generic;

public class Processor
{
	public Processor()
	{
	}
	
	public List<Drone> radar_and_picture(List<Drone> drones, List<Pixel> pixles)
	{

        List<Pixel> highIntensityPixels = new List<Pixel>();
        foreach (Pixel pixel in pixels)
		{
			if (pixel.Intensity > brightness_threshold)
			{
				highIntensityPixels.Add(pixel);
			}
		}

        List<Drone> coloredDrones = new List<Drone>();
		foreach (Drone drone in drones)
		{
			bool foundMatch = false;
            x_drone = drone.azimuth / (image_degree / image_size_x) + image_size_x / 2;
            foreach (Pixel pixel in highIntensityPixels)
			{
				if (Math.Abs(x_drone - pixel.X) <= degree_error_threshold)
				{
					drone.Color = Color.Blue;
					foundMatch = true;
					break;
				}
			}

			if (!foundMatch)
			{
				drone.Color = Color.Red;
			}
			coloredDrones.Add(drone);
		}
		return coloredDrones;
	}
}
