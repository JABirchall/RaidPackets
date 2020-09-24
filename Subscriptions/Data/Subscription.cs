
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Payments;
using SharedModel.Meta.Subscriptions.Enums;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Subscriptions.Data
{
	[MessagePackObject]
	public class Subscription
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public int? NextId;
		[Json]
		// [Key]
		public int GroupId;
		[Json]
		// [Key]
		public bool IsActive;
		[Json]
		// [Key]
		public DateTime BuyDate;
		[Json]
		// [Key]
		public DateTime ExpirationDate;
		[Json]
		// [Key]
		public SubscriptionSuspensionReason? SuspensionReason;
		[Json]
		// [Key]
		public string BillingTxId;
		[Json]
		// [Key]
		public DateTime? RefundTime;
		[Json]
		// [Key]
		public PurchasingPlatformId PurchasingPlatformId;
		[Json]
		// [Key]
		public UserPrize Prize;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public bool IsActiveOrWaitingForExtend { get => default; }
	
		// Constructors
		public Subscription() {}
	}
}
