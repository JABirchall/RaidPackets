
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.FeatureStatuses
{
	public enum FeatureStatus
	{
		DisabledForAll = 0,
		EnabledForAll = 2,
		EnabledForAdmins = 3
	}
}
