
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Payments
{
	[MessagePackObject]
	public class BillingPaymentSettings
	{
		// Fields
		[Json]
		// [Key]
		public string StartUrl;
		[Json]
		// [Key]
		public string ProcessUrl;
		[Json]
		// [Key]
		public string CheckSubscriptionUrl;
		[Json]
		// [Key]
		public string StartSubscriptionUrl;
		[Json]
		// [Key]
		public string CallbackSubscriptionUrl;
		[Json]
		// [Key]
		public string RestoreSubscriptionUrl;
	
		// Constructors
		public BillingPaymentSettings() {}
	}
}
