
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Battle.Core.Setup;
using SharedModel.Common.UserEdit;
using SharedModel.Meta.Account;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Village
{
	public static class VillageExtensions
	{
		// Methods
		public static BattleStats BuildCapitolBonusStats(BattleStats baseStats, BuildingSetup buildingSetup) => default;
	
		// Extension methods
		public static Building GetBuilding(this UserVillageData villageData, BuildingTypeId buildingTypeId) => default;
		public static BuildingLevelInfo GetLevelInfo(this Building building) => default;
		public static BuildingLevelInfo GetNextLevelInfo(this Building building) => default;
		public static bool IsMaxLevel(this Building building) => default;
		public static IUndoState Upgrade(this Building building) => default;
		public static int CalculateProducedGemsCount(this UserVillageData villageData, DateTime time, bool throwException) => default;
		public static double CalculateExcessGemMineHours(this UserVillageData villageData, DateTime normalizationTime) => default;
		public static UserVillageData InitCapitolDataIfNeeded(this UserVillageData data) => default;
		public static BuildingSetup ToBuildingSetup(this UserVillageData villageData, Element element) => default;
		public static UserVillageData AssertBuildingExists(this UserVillageData villageData, int id) => default;
		public static Building AssertMaxLevelIs(this Building building, bool isTrue) => default;
		public static Building AssertUpgradeCondition(this Building building, int userLevel) => default;
		public static Building AssertUpgradeCondition(this Building building, UserAccount account) => default;
		public static BuildingLevelInfo AssertNotNull(this BuildingLevelInfo levelInfo, bool throwException) => default;
		public static BuildingLevelInfo AssertIsValidGemsMineInfo(this BuildingLevelInfo levelInfo, bool throwException) => default;
		public static UserVillageData AssertHasProducedGems(this UserVillageData userVillageData) => default;
	}
}
