
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.BattlePasses;
using SharedModel.Meta.Offers;
using SharedModel.Meta.Offers.Dto;
using SharedModel.Meta.Offers.Enums;



namespace SharedModel.Meta.Payments
{
	[MessagePackObject]
	public class CheckCustomData
	{
		// Fields
		[Json]
		// [Key]
		public long? UserId;
		[Json]
		// [Key]
		public int? PaymentHandlerId;
		[Json]
		// [Key]
		public int? OpenOfferPromoId;
		[Json]
		// [Key]
		public int? GiveOfferId;
		[Json]
		// [Key]
		public BattlePassPaymentTypeId? BattlePassPaymentTypeId;
		[Json]
		// [Key]
		public ExposureLocation Exposure;
		[Json]
		// [Key]
		public OpenOfferDto OpenOffer;
		[Json]
		// [Key]
		public UserOffer GiveOffer;
	
		// Constructors
		public CheckCustomData() {}
		public CheckCustomData(long userId, BattlePassPaymentTypeId typeId) {}
	
		// Methods
		public CheckCustomData Clone() => default;
	}
}
