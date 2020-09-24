
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Offers
{
	[MessagePackObject]
	public class UserOfferProgressData
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<int, UserOfferPrizeInfo> PrizePerLevel;
	
		// Constructors
		public UserOfferProgressData() {}
	
		// Methods
		public UserOfferProgressData Clone() => default;
	}
}
