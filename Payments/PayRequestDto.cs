
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plarium.Common.Serialization;
using SharedModel.Meta.Payments.Data;



namespace SharedModel.Meta.Payments
{
	public class PayRequestDto
	{
		// Fields
		[Json]
		public string UserSocialId;
		[Json]
		public string BillingTransactionId;
		[Json]
		public BillingOperationType BillingOperationType;
		[Json]
		public string CheckCustomData;
		[Json]
		public Dictionary<string, string> Parameters;
		[Json]
		public double Amount;
		[Json]
		public string Currency;
	
		// Constructors
		public PayRequestDto() {}
	}
}
