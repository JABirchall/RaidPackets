
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Offers.Enums;
using SharedModel.Meta.Payments;



namespace SharedModel.Meta.Offers.Dto
{
	[MessagePackObject]
	public class GiveOfferDto
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
		public int SegmentId;
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
		public long UserId;
		[Json]
		// [Key]
		public Guid PromotionExposureId;
		[Json]
		// [Key]
		public double? DurationHours;
		[Json]
		// [Key]
		public DateTime? ValidTill;
		[Json]
		// [Key]
		public TriggerOfferDto TriggerData;
		[Json]
		// [Key]
		public AggressiveOfferDto AggressiveData;
		[Json]
		// [Key]
		public RetentionOfferDto RetentionOfferDto;
		[Json]
		// [Key]
		public string UserGroupLabel;
		[Json]
		// [Key]
		public string InterfaceSettingsJson;
		[Json]
		// [Key]
		public ChainOfferDto ChainOffer;
	
		// Constructors
		public GiveOfferDto() {}
	}
}
