
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Subscriptions.Enums
{
	public enum CancellationReason
	{
		Unknown = -1,
		ByUser = 1,
		BySystem = 2
	}
}
