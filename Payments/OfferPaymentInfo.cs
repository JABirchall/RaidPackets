
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Inbox;
using SharedModel.Meta.Offers.Dto;
using SharedModel.Meta.Offers.Enums;



namespace SharedModel.Meta.Payments
{
	[MessagePackObject]
	public class OfferPaymentInfo
	{
		// Fields
		[Json]
		// [Key]
		public int? Id;
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
		public int? SegmentId;
		[Json]
		// [Key]
		public Guid? PromotionExposureId;
		[Json]
		// [Key]
		public AggressiveOfferDto AggressiveData;
		[Json]
		// [Key]
		public TriggerOfferDto TriggerData;
		[Json]
		// [Key]
		public RetentionOfferDto RetentionData;
		[Json]
		// [Key]
		public List<InboxItem> InboxItems;
		[Json]
		// [Key]
		public double? WithholdGemsForRefund;
		[Json]
		// [Key]
		public bool IsOverdue;
		[Json]
		// [Key]
		public double? PrizeMultiplier;
		[Json]
		// [Key]
		public string OrderId;
		[Json]
		// [Key]
		public ExposureLocation Exposure;
		[Json]
		// [Key]
		public ChainOfferDto ChainOffer;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public bool IsOpenOffer { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool IsGiveOffer { get => default; }
	
		// Constructors
		public OfferPaymentInfo() {}
	}
}
