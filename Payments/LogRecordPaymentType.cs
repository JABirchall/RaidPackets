
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Payments
{
	public enum LogRecordPaymentType
	{
		Payment = 1,
		Refund = 2,
		SubscriptionOperation = 3,
		GooglePointsOperation = 4
	}
}
