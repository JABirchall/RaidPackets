
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
	public class ChainOfferDto
	{
		// Fields
		[Json]
		// [Key]
		public int PromotionId;
		[Json]
		// [Key]
		public int RunId;
		[Json]
		// [Key]
		public int ChainId;
	
		// Constructors
		public ChainOfferDto() {}
	
		// Methods
		public ChainOfferDto Clone() => default;
	}
}
