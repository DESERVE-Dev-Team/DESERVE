﻿using DESERVE.Managers;
using DESERVE.ReflectionWrappers.SandboxGameWrappers;
using System;
using System.Globalization;
using System.Reflection;
using System.Threading;
using SysUtils.Utils;
using VRage.Common.Utils;

namespace DESERVE.ReflectionWrappers.DedicatedServerWrappers
{
	public class Program : ReflectionClassWrapper
	{
		#region Fields
		private const String Class = "49BCFF86BA276A9C7C0D269C2924DE2D";

		private ReflectionMethod m_startupMethod;

		private Boolean m_isRunning;
		private ManualResetEvent m_waitEvent;
		#endregion

		#region Events
		public delegate void ServerRunningEvent();
		public event ServerRunningEvent OnServerStarted;
		public event ServerRunningEvent OnServerStopped;
		#endregion

		#region Properties
		public override String ClassName { get { return "Program"; } }
		public override String AssemblyName { get { return "SpaceEngineersDedicated"; } }
		private Boolean isRunning
		{
			get { return m_isRunning; }
			set
			{
				if (m_isRunning == value)
				{
					return;
				}
				m_isRunning = value;
				if (m_isRunning)
				{
					if (OnServerStarted != null)
					{
						OnServerStarted();
					}
				}
				else
				{
					if (OnServerStopped != null)
					{
						OnServerStopped();
					}
				}
			}
		}
		public Boolean IsRunning { get { return isRunning; } }
		#endregion

		#region Methods
		public Program(Assembly Assembly, String Namespace)
			: base(Assembly, Namespace, Class)
		{
			SetupReflection(Assembly);
			m_waitEvent = new ManualResetEvent(false);
		}

		private void SetupReflection(Assembly Assembly)
		{
			try
			{
				m_startupMethod = new ReflectionMethod(Assembly.EntryPoint.Name, ClassName, m_classType);
			}
			catch (ArgumentException ex)
			{
				LogManager.ErrorLog.WriteLineAndConsole(ex.ToString());
			}
		}

		public Thread StartServer(Object args)
		{
			LogManager.MainLog.WriteLineAndConsole("DESERVE: Loading server.");

			SandboxGameWrapper.MainGame.RegisterOnLoadedAction((Action)(() => this.m_waitEvent.Set()));

			Thread serverThread = new Thread(new ParameterizedThreadStart(this.ThreadStart));

			serverThread.IsBackground = true;
			serverThread.CurrentCulture = CultureInfo.InvariantCulture;
			serverThread.CurrentUICulture = CultureInfo.InvariantCulture;
			serverThread.Start(args);

			// Wait for map to load.
			m_waitEvent.WaitOne();

			LogManager.MainLog.WriteLineAndConsole("DESERVE: Server loaded.");

			isRunning = true;

			return serverThread;
		}

		private void ThreadStart(Object args)
		{
			try
			{
				if (MyLog.Default != null)
					MyLog.Default.Close();
				MyFileSystem.Reset();
				DedicatedServerWrapper.Program.Start(args as Object[]);
			}
			catch (Exception ex)
			{
				LogManager.MainLog.WriteLineAndConsole("Unhandled Exception! Server Stopped.");
				LogManager.ErrorLog.WriteLine("Unhandled Exception caused server to crash. Exception: " + ex.ToString());
			}
			isRunning = false;
		}

		private void Start(Object[] args)
		{
			m_startupMethod.Call(null, args);
		}
		#endregion
	}
}
