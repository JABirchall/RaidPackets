
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Offers.Enums;
using SharedModel.Meta.Payments;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Offers.Dto
{
	[MessagePackObject]
	public class OpenOfferDto
	{
		// Fields
		[Json]
		// [Key]
		public int PromoOfferId;
		[Json]
		// [Key]
		public OfferTypeId TypeId;
		[Json]
		// [Key]
		public int Revision;
		[Json]
		// [Key]
		public int? PriceId;
		[Json]
		// [Key]
		public Account.Resources Price;
		[Json]
		// [Key]
		public UnitedPrize Prize;
		[Json]
		// [Key]
		public PurchaseLimit PurchaseLimit;
		[Json]
		// [Key]
		public double? NewUserDelayInHours;
		[Json]
		// [Key]
		public string InterfaceSettingsJson;
		[Json]
		// [Key]
		public ProgressOfferDto ProgressOfferDto;
		[Json]
		// [Key]
		public RetentionOfferDto RetentionOfferDto;
		[Json]
		// [Key]
		public DynamicPriceOfferDto DynamicPriceOfferDto;
		[Json]
		// [Key]
		public string UserGroupLabel;
		[Json]
		// [Key]
		public double? PrizeMultiplier;
		[IgnoreMember]
		[JsonSkip]
		private UserPrize _userPrize;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public UserPrize UserPrize { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool IsAbRetention { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool HasPurchaseLimit { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool HasDynamicPrice { get => default; }
	
		// Constructors
		public OpenOfferDto() {}
	
		// Methods
		public OpenOfferDto Clone() => default;
		public OpenOfferDto CloneForLogging() => default;
		public bool SameUserGroupLabel(string label) => default;
	}
}
