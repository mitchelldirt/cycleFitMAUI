﻿using ObjCRuntime;
using UIKit;

namespace cycleFitMAUI;

public class Program
{
	// This is the main entry point of the application.
	static void Main(string[] args)
	{
		// if you want to use a different Application Delegate class from "AppDelegate"
		// you can specify it here.
		Thread.Sleep(5000);
		UIApplication.Main(args, null, typeof(AppDelegate));
	}
}
