
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.HeroesRating;



namespace SharedModel.Meta.Heroes
{
	[MessagePackObject]
	public class UserHeroData
	{
		// Fields
		[Json]
		// [Key]
		public int LastHeroId;
		[Json]
		// [Key]
		public Dictionary<int, Hero> HeroById;
		[Json]
		// [Key]
		public int InventorySlotsCount;
		[Json]
		// [Key]
		public int StorageSlotsCount;
		[Json]
		// [Key]
		public Dictionary<int, int[]> BattlePresets;
		[Json]
		// [Key]
		public List<int> SeenHeroTypeIds;
		[Json]
		// [Key]
		public List<int> OwnedHeroTypeIds;
		[Json]
		// [Key]
		public Dictionary<int, HeroRatingData> HeroRatingByHeroTypeId;
		[Json]
		// [Key]
		public Dictionary<int, List<FuseHeroInfo>> FuseInfosByOutputHeroId;
		[Json]
		// [Key]
		public Dictionary<int, int> FusedHeroesCountById;
		[Json]
		// [Key]
		public Dictionary<int, DateTime> SeenFuseDateByHeroTypeId;
		[Json]
		// [Key]
		public Dictionary<int, int> HeroParts;
		[Json]
		// [Key]
		public Dictionary<int, int> SeenHeroPartsCountById;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public int InventoryHeroesCount { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public int StorageHeroesCount { get => default; }
	
		// Constructors
		public UserHeroData() {}
	
		// Methods
		protected bool Equals(UserHeroData other) => default;
	}
}
