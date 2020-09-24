
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
	public class UserBlackMarketData
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<BlackMarketItemId, BmiBox> Items;
	
		// Constructors
		public UserBlackMarketData() {}
	}
}
