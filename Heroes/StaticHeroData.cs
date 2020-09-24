
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.Heroes
{
	[MessagePackObject]
	public class StaticHeroData
	{
		// Fields
		[Json]
		// [Key]
		public List<HeroType> HeroTypes;
		[Json]
		// [Key]
		public Dictionary<int, int> HeroExperienceByKey;
		[Json]
		// [Key]
		public Dictionary<int, int> SacrificeExperienceByKey;
		[Json]
		// [Key]
		public Dictionary<HeroGrade, int> RankHeroCountByGrade;
		[Json]
		// [Key]
		public Dictionary<HeroGrade, int> RankSilverByGrade;
		[Json]
		// [Key]
		public Dictionary<HeroGrade, Account.Resources> LevelUpPriceByGrade;
		[Json]
		// [Key]
		public Dictionary<HeroRace, List<HeroFraction>> FractionsByRace;
		[Json]
		// [Key]
		public Dictionary<HeroRarity, List<int>> HeroIdsByRarities;
		[Json]
		// [Key]
		public int LevelUpMaterialsLimit;
		[Json]
		// [Key]
		public int MultipleHeroesSummonCount;
		[Json]
		// [Key]
		public int MaxInventorySlotsCount;
		[Json]
		// [Key]
		public int MaxStorageSlotsCount;
		[Json]
		// [Key]
		public List<InventorySlotsPrice> InventorySlotsPrices;
		[Json]
		// [Key]
		public List<InventorySlotsPrice> StorageSlotsPrices;
		[Json]
		// [Key]
		public int[] HeroesOnIntroFinish;
		[Json]
		// [Key]
		public double HeroRatingUpdateCooldownMinutes;
		[Json]
		// [Key]
		public Dictionary<int, int> HeroPartsCountByHeroType;
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<int, HeroType> HeroTypeById;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<HeroFraction, HeroRace> _raceByFraction;
		[IgnoreMember]
		[JsonSkip]
		private List<HeroFraction> _activeFractions;
		[IgnoreMember]
		[JsonSkip]
		public List<int> UserAvailableBaseHeroIds;
		[IgnoreMember]
		[JsonSkip]
		public List<HeroFraction> Fractions;
		[IgnoreMember]
		[JsonSkip]
		public List<Element> Elements;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public List<HeroFraction> ActiveFractions { get => default; }
	
		// Constructors
		public StaticHeroData() {}
	
		// Methods
		public void Cache() {}
		public HeroFraction GetHeroFraction(int typeId) => default;
		public HeroType GetHeroType(int typeId, bool throwExceptionIfNotFound = true) => default;
		public int GetMaxExperience(HeroGrade grade, int level) => default;
		public HeroRace GetRace(HeroFraction fraction) => default;
		public int GetFullExperience(HeroGrade grade, int level) => default;
		public float GetNormalizedLevel(HeroGrade grade, int absoluteExperience) => default;
	}
}
