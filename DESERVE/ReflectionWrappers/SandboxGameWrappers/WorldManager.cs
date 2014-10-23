﻿using DESERVE.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DESERVE.ReflectionWrappers.SandboxGameWrappers
{
	class WorldManager : ReflectionClassWrapper
	{
		#region Fields
		private const String Class = "D580AE7552E79DAB03A3D64B1F7B67F9";
		private ReflectionMethod m_save;
		private ReflectionField m_instance;

		private Boolean m_isSaving;
		#endregion

		#region Properties
		public override String ClassName { get { return "WorldManager"; } }
		public override String AssemblyName { get { return "Sandbox.Game"; } }
		public Object Instance { get { return m_instance.GetValue(null); } }
		public Boolean IsSaving 
		{
			get { return m_isSaving; }
			set
			{
				if (m_isSaving == value)
				{
					return;
				}
				m_isSaving = value;
				if (IsSavingChanged != null)
				{
					IsSavingChanged(m_isSaving);
				}
			}
		}
		#endregion

		#region Events
		public delegate void SavingEventHandler(Boolean isSaving);
		public event SavingEventHandler IsSavingChanged;
		#endregion

		#region Methods
		public WorldManager(Assembly Assembly, String Namespace)
			: base(Assembly, Namespace, Class)
		{
			SetupReflection();
		}

		private void SetupReflection()
		{
			try
			{
				m_save = new ReflectionMethod("50092B623574C842837BD09CE21A96D6", Class, m_classType);
			}
			catch (ArgumentException ex)
			{
				LogManager.ErrorLog.WriteLineAndConsole(ex.ToString());
			}
			try
			{
				m_instance = new ReflectionField("AE8262481750DAB9C8D416E4DBB9BA04", Class, m_classType);
			}
			catch (ArgumentException ex)
			{
				LogManager.ErrorLog.WriteLineAndConsole(ex.ToString());
			}
		}

		public void Save()
		{
			SandboxGameWrapper.MainGame.EnqueueAction(SaveWorld);
		}

		/// <summary>
		/// Must be called from the main server thread. NOT the DESERVE program thread.
		/// </summary>
		private void SaveWorld()
		{
			IsSaving = true;

			LogManager.MainLog.WriteLineAndConsole("DESERVE: Saving world.");

			DateTime saveStartTime = DateTime.Now;

			String arg0 = "";
			Object[] args = 
			{
				arg0
			};

			bool result = (bool)m_save.Call(Instance, args);

			if (result)
			{
				TimeSpan timeToSave = DateTime.Now - saveStartTime;
				LogManager.MainLog.WriteLineAndConsole("DESERVE: Save complete and took " + timeToSave.TotalSeconds + " seconds");
			}
			else
			{
				LogManager.ErrorLog.WriteLineAndConsole("DESERVE: Save Failed!");
			}

			IsSaving = false;
		}
		#endregion
	}

	public class ServerSavingEventHandler
	{

	}
}
