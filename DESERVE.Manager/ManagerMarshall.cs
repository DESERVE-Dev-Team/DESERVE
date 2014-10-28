﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using System.Runtime.Serialization;
using System.ServiceModel;
using DESERVE.Common;
using DESERVE.Common.Marshall;

using DESERVE.Manager.ErrorHandlers;
using DESERVE.Manager.Managers;

namespace DESERVE.Managers
{
	[WCFErrorBehaviorAttribute(typeof(WCFErrorHandler))]
	public class ManagerMarshall : IManagerMarshall
	{
		#region Fields
		#endregion

		#region Properties
		#endregion

		#region Methods
		public void ReportInstanceName(string instanceName)
		{
			try
			{
				InstanceManager.Instance.RefreshServer(instanceName);
			}
			catch (Exception)
			{	
				throw;
			}	
		}
		#endregion

	}
}
