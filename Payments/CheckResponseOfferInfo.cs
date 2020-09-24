
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
	public class CheckResponseOfferInfo
	{
		// Fields
		[Json]
		// [Key]
		public int OfferId;
		[Json]
		// [Key]
		public int? PromotionId;
		[Json]
		// [Key]
		public int? PromotionRunId;
	
		// Constructors
		public CheckResponseOfferInfo() {}
		public CheckResponseOfferInfo(int offerId, int? promotionId = default, int? promotionRunId = default) {}
	
		// Methods
		public CheckResponseOfferInfo Clone() => default;
	}
}
