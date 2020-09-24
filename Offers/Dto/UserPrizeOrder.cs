
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.BlackMarket;



namespace SharedModel.Meta.Offers.Dto
{
	[MessagePackObject]
	public class UserPrizeOrder
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<ResourceTypeId, int> ResourcesOrder;
		[Json]
		// [Key]
		public Dictionary<BlackMarketItemId, int> BlackMarketOrder;
		[Json]
		// [Key]
		public Dictionary<int, int> HeroOrder;
	
		// Constructors
		public UserPrizeOrder() {}
	}
}
