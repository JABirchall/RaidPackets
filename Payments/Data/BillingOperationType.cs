
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Payments.Data
{
	public enum BillingOperationType
	{
		Payment = 0,
		Refund = 1,
		SubscriptionOperation = 3
	}
}
