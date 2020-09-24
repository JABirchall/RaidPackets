
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Subscriptions.Enums
{
	public enum SubscriptionOperation
	{
		RemoveObsolete = -2,
		Read = -1,
		Buy = 1,
		Refund = 2,
		Extend = 3,
		Cancel = 4,
		Change = 5,
		Resubscribe = 6,
		StartChangePlan = 7,
		Migrate = 8
	}
}
