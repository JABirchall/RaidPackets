
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Payments.Data
{
	public enum PurchaseResult
	{
		Unknown = 0,
		SuccessSendToGs = 1,
		InvalidSignature = 2,
		Duplicate = 4,
		InvalidProduct = 5,
		PurchaseExpired = 8,
		InvalidApp = 9,
		InvalidTransactionId = 10,
		InvalidReceipt = 11,
		PurchaseNotFound = 13,
		InvalidPaymentData = 14
	}
}
