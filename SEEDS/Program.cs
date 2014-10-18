﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SEEDS
{
	class SEEDS
	{
		#region Attributes
		private CommandLineArgs m_commandLineArgs;
		private ServerManager m_serverManager;
		#endregion

		#region Properties
		static public Version Version { get { return Assembly.GetEntryAssembly().GetName().Version; } }
		static public String BuildBranch { get { return "Dev"; } }
		static public String VersionString { get { return Version.ToString(3) + " " + BuildBranch; } }
		#endregion

		#region Methods
		static void Main(string[] args)
		{
			SEEDS program = new SEEDS(args);
		}

		public SEEDS(string[] args)
		{
			m_commandLineArgs = new CommandLineArgs(args);
			m_serverManager = new ServerManager();
			m_serverManager.StartServer("Project Vengeance");

			while (m_serverManager.ServerInstances.Count > 0)
			{
				Thread.Sleep(50);
			}
		}
		#endregion
	}
}
