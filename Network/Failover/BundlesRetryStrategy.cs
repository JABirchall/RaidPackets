
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Network.Failover
{
	public enum BundlesRetryStrategy
	{
		RetryForMaxAttempts = 0,
		ReEnqueue = 1
	}
}
