﻿using System;
using System.Collections.Generic;

namespace Utilities
{
	public static class Helper
	{
		
		public static string User { get; set; } = "Admin123";
		public static string Password { get; set; } = "Admin123";
		public static void SetMessageAndColor(string message,ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.WriteLine(message);
			Console.ResetColor();
		}
	}
}

