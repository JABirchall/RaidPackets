
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Offers.Dto;
using SharedModel.Meta.Subscriptions.Enums;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Subscriptions.Dtos
{
	[MessagePackObject]
	public class SubscriptionDto
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public bool IsActiveSubscription;
		[Json]
		// [Key]
		public int PeriodInMonths;
		[Json]
		// [Key]
		public SubscriptionTypeId Type;
		[Json]
		// [Key]
		public int GroupId;
		[Json]
		// [Key]
		public string IapProductSku;
		[Json]
		// [Key]
		public SubscriptionAmountDto[] Amounts;
		[Json]
		// [Key]
		public int? Discount;
		[Json]
		// [Key]
		public bool IsFreeTrial;
		[Json]
		// [Key]
		public int TrialPeriodInDays;
		[Json]
		// [Key]
		public string PrizeStr;
		[Json]
		// [Key]
		public string InterfaceSettingsJson;
		[IgnoreMember]
		[JsonSkip]
		private InterfaceSettingsDto _interfaceSettings;
		[IgnoreMember]
		[JsonSkip]
		private UserPrize _prize;
		[IgnoreMember]
		[JsonSkip]
		public double Amount;
		[IgnoreMember]
		[JsonSkip]
		public string Currency;
		[IgnoreMember]
		[JsonSkip]
		public string Price;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public InterfaceSettingsDto InterfaceSettings { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public UserPrize Prize { get => default; }
	
		// Constructors
		public SubscriptionDto() {}
	}
}
