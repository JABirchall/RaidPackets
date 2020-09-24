
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Offers.Dto;
using SharedModel.Meta.Offers.Enums;
using SharedModel.Meta.Payments;



namespace SharedModel.Meta.Offers
{
	[MessagePackObject]
	public class UserOffer
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public int PromoOfferId;
		[Json]
		// [Key]
		public int PriceId;
		[Json]
		// [Key]
		public Account.Resources Price;
		[Json]
		// [Key]
		public string BillingTransactionId;
		[Json]
		// [Key]
		public int Revision;
		[Json]
		// [Key]
		public int? SegmentId;
		[Json]
		// [Key]
		public Guid? PromotionExposureId;
		[Json]
		// [Key]
		public OfferTypeId TypeId;
		[Json]
		// [Key]
		public OfferStateId StateId;
		[Json]
		// [Key]
		public PurchaseLimit PurchaseLimit;
		[Json]
		// [Key]
		public UnitedPrize Prize;
		[Json]
		// [Key]
		public DateTime? GivenTime;
		[Json]
		// [Key]
		public DateTime? ValidTill;
		[Json]
		// [Key]
		public List<DateTime> PurchaseDates;
		[Json]
		// [Key]
		public UserOfferRetentionData RetentionData;
		[Json]
		// [Key]
		public UserOfferProgressData ProgressData;
		[Json]
		// [Key]
		public TriggerOfferDto TriggerData;
		[Json]
		// [Key]
		public AggressiveOfferDto AggressiveData;
		[Json]
		// [Key]
		public ChainOfferDto ChainOfferData;
		[Json]
		// [Key]
		public UserOfferDynamicPriceData DynamicPriceData;
		[Json]
		// [Key]
		public string UserGroupLabel;
		[Json]
		// [Key]
		public string InterfaceSettingsJson;
		[IgnoreMember]
		[JsonSkip]
		private InterfaceSettingsDto _interfaceSettings;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public DateTime LastPurchaseTime { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public int BoughtCount { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public int? PromotionId { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public int? PromotionRunId { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public InterfaceSettingsDto InterfaceSettings { get => default; }
	
		// Constructors
		public UserOffer() {}
	
		// Methods
		public UserOffer Clone() => default;
		public UserOffer CloneForLogging() => default;
	}
}
