
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Payments.Log
{
	public enum ClientStepId
	{
		Start = 1,
		Native = 2,
		Callback = 3,
		SubscriptionCheck = 4
	}
}
