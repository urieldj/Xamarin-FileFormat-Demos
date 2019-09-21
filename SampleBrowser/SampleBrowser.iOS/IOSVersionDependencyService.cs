﻿using System;
using bryant.Forms;
using UIKit;
using bryant.Forms.Platform.iOS;
using SampleBrowser;
using SampleBrowser.iOS;

[assembly: Dependency(typeof(IOSVersionDependencyService))]
namespace SampleBrowser.iOS
{
	internal class IOSVersionDependencyService : IIOSVersionDependencyService
	{
		public double GetIOSVersion()
		{
			string[] iOS_Version = (UIDevice.CurrentDevice.SystemVersion).Split('.');
			return Convert.ToDouble(iOS_Version[0]);
		}
	}
}

