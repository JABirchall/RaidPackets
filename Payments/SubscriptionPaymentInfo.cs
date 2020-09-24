
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Offers.Enums;
using SharedModel.Meta.Subscriptions.Enums;



namespace SharedModel.Meta.Payments
{
	[MessagePackObject]
	public class SubscriptionPaymentInfo
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public SubscriptionTypeId TypeId;
		[Json]
		// [Key]
		public int DurationInMonth;
		[Json]
		// [Key]
		public bool IsFreeTrial;
		[Json]
		// [Key]
		public SubscriptionOperation Operation;
		[Json]
		// [Key]
		public ExposureLocation Exposure;
		[Json]
		// [Key]
		public DateTime BuyDate;
		[Json]
		// [Key]
		public int SubscriptionDepositIndex;
	
		// Constructors
		public SubscriptionPaymentInfo() {}
	}
}
