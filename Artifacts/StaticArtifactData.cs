
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Effects;
using SharedModel.Common.Attributes;
using SharedModel.Meta.Account;
using SharedModel.Meta.Artifacts.Bonuses;
using SharedModel.Meta.Artifacts.Sets;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Artifacts
{
	[MessagePackObject]
	// [RemovedJson]
	public class StaticArtifactData
	{
		// Fields
		public const int UpgradeFailuresToIncreaseChance = 27;
		public const double IncreaseChanceStep = 0.1;
		[Json]
		// [Key]
		public ArtifactSettings Settings;
		[Json]
		// [Key]
		public List<ArtifactSetInfo> SetInfos;
		[Json]
		// [Key]
		public List<PrimaryArtifactBonusInfo> PrimaryBonusInfos;
		[Json]
		// [Key]
		public List<SecArtifactBonusInfo> SecBonusInfos;
		[Json]
		// [Key]
		public Dictionary<int, Dictionary<ArtifactRarityId, int>> SecAdditionalBonusCountByRarityAndLevel;
		[Json]
		// [Key]
		public Dictionary<ArtifactRankId, Account.Resources> DeactivatePriceByRank;
		[Json]
		// [Key]
		public Dictionary<ArtifactRankId, Account.Resources[]> UpgradePricesByRank;
		[Json]
		// [Key]
		public Dictionary<ArtifactRankId, Account.Resources[]> UpgradePricesByRankAccessories;
		[Json]
		// [Key]
		public double[] UpgradeChances;
		[Json]
		// [Key]
		public Dictionary<ArtifactSetKindId, int> BasePriceBySetKindId;
		[Json]
		// [Key]
		public Dictionary<ArtifactRankId, int> PriceMultiplierByRankId;
		[Json]
		// [Key]
		public Dictionary<ArtifactRarityId, double> PriceMultiplierByRarityId;
		[Json]
		// [Key]
		public Dictionary<ArtifactKindId, double> PriceMultiplierByKindId;
		[Json]
		// [Key]
		public Dictionary<ArtifactRankId, double> SellPriceMultiplierByRankId;
		[Json]
		// [Key]
		public Dictionary<ArtifactKindId, HeroGrade> RequiredHeroGradeByKindId;
		[Json]
		// [Key]
		public Dictionary<ArtifactKindId, ArtifactSlotOpenCondition> SlotOpenConditionByKindId;
		[Json]
		// [Key]
		public bool DeleteArtifactEnabled;
		[Json]
		// [Key]
		public int MaxArtifactsCount;
		[Json]
		// [Key]
		public int MaxArtifactLevel;
		[Json]
		// [Key]
		public int GradationUpgradeConstraintLevel;
		[Json]
		// [Key]
		public int DefaultSetPrice;
		[Json]
		// [Key]
		public bool FilterEnabled;
		[Json]
		// [Key]
		public int SecondaryStatsSelectionLimit;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<ArtifactSetKindId, ArtifactSetInfo> _setInfoByKind;
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<ArtifactKindId, List<PrimaryArtifactBonusInfo>> PrimaryBonusesByKindId;
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<ArtifactKindId, List<SecArtifactBonusInfo>> SecondaryBonusesByKindId;
		[IgnoreMember]
		[JsonSkip]
		public List<ArtifactKindId> ArtifactKindIds;
		[IgnoreMember]
		[JsonSkip]
		public List<ArtifactKindId> AccessoryKindIds;
		[IgnoreMember]
		[JsonSkip]
		public List<ArtifactRarityId> ArtifactRarityIds;
		[IgnoreMember]
		[JsonSkip]
		public List<ArtifactRankId> ArtifactRankIds;
		[IgnoreMember]
		[JsonSkip]
		public List<ArtifactSetKindId> ArtifactSetKindIds;
		[IgnoreMember]
		[JsonSkip]
		public List<ArtifactSetKindId> AccessorySetKindIds;
	
		// Constructors
		public StaticArtifactData() {}
	
		// Methods
		public void Cache() {}
		public ArtifactSetInfo GetSetInfo(ArtifactSetKindId kindId) => default;
		public int GetSecBonusCount(int level, ArtifactRarityId rarityId) => default;
		public SecArtifactBonusValue GetSecBonusValue(ArtifactKindId artifactKindId, StatKindId kindId, bool isAbsolute, ArtifactRankId rankId) => default;
		public Account.Resources GetUpgradePrice(ArtifactRankId rankId, int level, bool isAccessory) => default;
		public double GetUpgradeChance(int level, int failedUpgradesCount) => default;
		public int GetBasePrice(ArtifactSetKindId setKindId) => default;
		public int GetRankPriceMultiplier(ArtifactRankId rankId) => default;
		public double GetRarityPriceMultiplier(ArtifactRarityId rarityId) => default;
		public double GetSellPriceMultiplier(ArtifactRankId rankId) => default;
		public double GetKindPriceMultiplier(ArtifactKindId kindId) => default;
		public HeroGrade GetRequiredHeroGrade(ArtifactKindId kindId) => default;
		public bool CheckSlotOpenCondition(ArtifactKindId kindId, Hero hero) => default;
		public StaticArtifactData AddUpgradePrice(ArtifactRankId rankId, Account.Resources[] pricesByLevel, bool isAccessory = false) => default;
		public void AssertUpgradePricesInRange(int maxLevel) {}
	}
}
