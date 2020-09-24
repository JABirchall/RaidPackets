
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Subscriptions.Enums
{
	public enum SubscriptionSuspensionReason
	{
		Change = 1,
		Cancel = 2,
		WaitingForExtend = 3,
		Refund = 4
	}
}
