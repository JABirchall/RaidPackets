
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Offers.Dto
{
	[MessagePackObject]
	public class CloseOfferDto
	{
		// Fields
		[Json]
		// [Key]
		public AggressiveOfferDto AggressiveOfferData;
		[Json]
		// [Key]
		public ChainOfferDto ChainOfferData;
		[Json]
		// [Key]
		public int? PromotionId;
		[Json]
		// [Key]
		public int? PromotionRunId;
		[Json]
		// [Key]
		public int OfferId;
		[Json]
		// [Key]
		public long[] UserIds;
	
		// Constructors
		public CloseOfferDto() {}
	}
}
