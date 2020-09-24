
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
	public class AggressiveOfferDto
	{
		// Fields
		private const int IdWithoutSegmentation = -1;
		[Json]
		// [Key]
		public int PromotionId;
		[Json]
		// [Key]
		public int PromotionRunId;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public bool HasSegmentation { get => default; }
	
		// Constructors
		public AggressiveOfferDto() {}
	
		// Methods
		public bool Equals(AggressiveOfferDto other) => default;
		public AggressiveOfferDto Clone() => default;
	}
}
