
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.MagicShop
{
	[MessagePackObject]
	public class UserMagicShopData
	{
		// Fields
		[Json]
		// [Key]
		public int LastItemId;
		[Json]
		// [Key]
		public List<MagicShopItem> Items;
		[Json]
		// [Key]
		public DateTime LastRefreshTime;
		[Json]
		// [Key]
		public int SlotCount;
		[Json]
		// [Key]
		public int AncientShardPurchaseLastMonth;
		[Json]
		// [Key]
		public int AncientShardPurchaseCount;
	
		// Constructors
		public UserMagicShopData() {}
	}
}
