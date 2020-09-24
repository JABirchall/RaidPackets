
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Artifacts;
using SharedModel.Meta.BlackMarket;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.Quests.Data;



namespace SharedModel.Meta.PeriodicQuests.Data
{
	[MessagePackObject]
	public class StaticPeriodicQuestData
	{
		// Fields
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<PeriodicQuestPrototypeId, PointFilterFunc> PointFiltersByPrototypeId;
		[Json]
		// [Key]
		public Dictionary<int, double> DurationInHoursByGroupId;
		[Json]
		// [Key]
		public Dictionary<PeriodicQuestsPackId, List<int>> RandomDailyQuestPrototypeIdsByQuestPackId;
		[Json]
		// [Key]
		public Dictionary<PeriodicQuestsPackId, int> RandomQuestsCountByQuestPackId;
	
		// Nested types
		public delegate long? PointFilterFunc(ComplexSource cs, PeriodicQuestFilter filter);
	
		// Constructors
		public StaticPeriodicQuestData() {}
	
		// Methods
		private void InitFilters() {}
		private void SummonHeroesFilter() {}
		private void AscendHeroFilter() {}
		private void AscendHeroToSpecificGradeFilter() {}
		private void RankUpHeroFilter() {}
		private void SkillUpHeroFilter() {}
		private void UseEnergyFilter() {}
		private void LevelUpHeroFilter() {}
		private void UpgradeArtifactsFilter() {}
		private void UpgradeArtifactsToSpecificLevelFilter() {}
		private void PurchaseItemInMagicShopFilter() {}
		private void PerformPackFilter() {}
		private void ClearMapStagesFilter() {}
		private void DefeatStoryBossFilter() {}
		private void DefeatDungeonBossFilter() {}
		private void WinArenaBattlesFilter() {}
		private void CollectFreeShardsFilter() {}
		private void CompleteQuestsFilter() {}
		private void FightInArenaBattlesFilter() {}
	}
}
