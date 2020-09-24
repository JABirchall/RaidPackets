
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Attributes;
using SharedModel.Meta.Payments;



namespace SharedModel.Meta.Offers.Dto
{
	[MessagePackObject]
	// [RemovedJson]
	public class RetentionOfferDto
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<int, UnitedPrize> PrizePerDay;
		[Json]
		// [Key]
		public int? PromotionId;
		[Json]
		// [Key]
		public int? RunId;
	
		// Constructors
		public RetentionOfferDto() {}
		public RetentionOfferDto(int? promoId, int? runId) {}
	
		// Methods
		public RetentionOfferDto Clone() => default;
		public RetentionOfferDto CloneForLog() => default;
	}
}
