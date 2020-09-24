
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.MagicShop
{
	[MessagePackObject]
	public class StaticMagicShopData
	{
		// Fields
		[Json]
		// [Key]
		public MagicShopSettings Settings;
		[Json]
		// [Key]
		public int InitialSlotsCount;
		[Json]
		// [Key]
		public Account.Resources RefreshPrice;
		[Json]
		// [Key]
		public Dictionary<int, Account.Resources> SlotPriceByCount;
		[Json]
		// [Key]
		public Dictionary<int, Dictionary<int, double>> ItemChanceByLevelByType;
		[Json]
		// [Key]
		public Dictionary<int, Dictionary<int, double>> RankChanceByLevelByType;
		[Json]
		// [Key]
		public Dictionary<int, Dictionary<int, double>> SetChanceByLevelByType;
		[Json]
		// [Key]
		public Dictionary<int, Dictionary<int, double>> KindChanceByLevelByType;
		[Json]
		// [Key]
		public Dictionary<int, Dictionary<int, double>> RarityChanceByLevelByType;
		[Json]
		// [Key]
		public Dictionary<int, List<Account.Resources>> HeroSellPricesByType;
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<int, Dictionary<int, double>> ItemChanceByLevelByTypeWithoutAncientShard;
	
		// Constructors
		public StaticMagicShopData() {}
	
		// Methods
		public void Cache() {}
	}
}
