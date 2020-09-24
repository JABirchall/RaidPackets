
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Payments;



namespace SharedModel.Meta.Offers.Dto
{
	[MessagePackObject]
	public class ProgressOfferDto
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<int, UnitedPrize> PrizePerLevel;
	
		// Constructors
		public ProgressOfferDto() {}
	
		// Methods
		public ProgressOfferDto Clone() => default;
	}
}
