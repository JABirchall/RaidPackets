
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Attributes;
using SharedModel.Meta.Offers.Dto;



namespace SharedModel.Meta.Offers
{
	[MessagePackObject]
	// [RemovedJson]
	public class UserOfferRetentionData
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<int, UserOfferPrizeInfo> PrizePerDay;
		[Json]
		// [Key]
		public int? PromotionId;
		[Json]
		// [Key]
		public int? RunId;
	
		// Constructors
		public UserOfferRetentionData() {}
	
		// Methods
		public UserOfferRetentionData Clone() => default;
		public RetentionOfferDto ToRetentionDto() => default;
	}
}
