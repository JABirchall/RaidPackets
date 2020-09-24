
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.BlackMarket
{
	[MessagePackObject]
	public class StaticBlackMarketData
	{
		// Fields
		[Json]
		// [Key]
		public List<BlackMarketItem> Items;
		[Json]
		// [Key]
		public BlackMarketSettings BlackMarketSettings;
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<BlackMarketItemId, BlackMarketItem> ItemById;
	
		// Constructors
		public StaticBlackMarketData() {}
	
		// Methods
		public void Cache() {}
		public BlackMarketItem GetItem(BlackMarketItemId id) => default;
	}
}
