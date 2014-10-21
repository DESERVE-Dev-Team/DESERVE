﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DESERVE
{
	public class CommandLineArgs
	{
		#region Fields
		#endregion

		#region Properties
		public Int32 AutosaveSeconds { get; set; }
		public String Instance { get; set; }
		public Boolean Debug { get; set; }
		public String LogDirectory { get; set; }
		#endregion

		public CommandLineArgs(string[] args)
		{
			// Set Defaults.
			AutosaveSeconds = -1;
			Instance = "";
			Debug = false;
			LogDirectory = Directory.GetCurrentDirectory() + "\\DESERVE";

			// Process Commandline.
			int numArgs = args.GetLength(0);
			int i = 0;
			while (numArgs != i)
			{
				string currentArg = args[i].ToLower();
				switch (currentArg)
				{
					case "-autosave":
						if (i + 1 != numArgs)
						{
							Int32 autoSave;
							if (Int32.TryParse(args[i + 1], out autoSave))
							{
								AutosaveSeconds = autoSave;
								i++;
							}
							else
							{
								Console.WriteLine("Argument Error: -autosave duration \"" + args[i + 1] + "\" invalid.");
							}
						}
						else
						{
							Console.WriteLine("Argument Error: -autosave duration not specified.");
						}
						break;
					case "-instance":
						if (i + 1 != numArgs)
						{
							Instance = args[i + 1];
							i++;
						}
						else
						{
							Console.WriteLine("Argument Error: -autostart world not specified.");
						}
						break;
					case "-debug":
						Debug = true;
						break;
				}

				i++;
			}
		}

	}
}
