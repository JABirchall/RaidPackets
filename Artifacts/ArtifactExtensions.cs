
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Battle.Core.Setup;
using SharedModel.Battle.Effects;
using SharedModel.Common.Math;
using SharedModel.Common.UserEdit;
using SharedModel.Meta.Artifacts.Bonuses;
using SharedModel.Meta.Artifacts.Sets;
using SharedModel.Meta.BlackMarket;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Artifacts
{
	public static class ArtifactExtensions
	{
		// Nested types
		private sealed class ArtifactBonusesEnumerable : IEnumerable<ArtifactBonus>
		{
			// Fields
			private readonly Artifact _artifact;
	
			// Constructors
			public ArtifactBonusesEnumerable() {} // Dummy constructor
			public ArtifactBonusesEnumerable(Artifact artifact) {}
	
			// Methods
			// [IteratorStateMachine]
			public IEnumerator<ArtifactBonus> GetEnumerator() => default;
			IEnumerator IEnumerable.GetEnumerator() => default;
		}
	
		// Methods
		public static BattleStats BuildArtifactBonusStats(BattleStats baseStats, Dictionary<ArtifactKindId, Artifact> artifacts) => default;
		public static BattleStats BuildArtifactBonusStats(BattleStats baseStats, List<ArtifactSetup> artifacts, List<ArtifactSetSetup> setSetups = null) => default;
		public static BattleStats SumFlatArtifactBonusStats(IEnumerable<ArtifactSetup> artifacts, List<ArtifactSetSetup> setSetups) => default;
		public static BattleStats SumPercentArtifactBonusStats(IEnumerable<ArtifactSetup> artifacts, List<ArtifactSetSetup> setSetups) => default;
	
		// Extension methods
		public static Artifact ArtifactOrThrow(this UserArtifactData data, int with) => default;
		public static Artifact Artifact(this UserArtifactData data, int with) => default;
		private static Artifact BinarySearch(this List<Artifact> artifacts, int id) => default;
		// [IteratorStateMachine]
		public static IEnumerable<Artifact> GetFreeArtifacts(this UserArtifactData data) => default;
		public static HeroArtifactData GetHeroArtifactData(this UserArtifactData data, int heroId) => default;
		public static Dictionary<ArtifactKindId, Artifact> GetHeroArtifacts(this UserArtifactData data, int heroId) => default;
		public static int? GetHeroSlotArtifactId(this UserArtifactData data, int heroId, ArtifactKindId kindId) => default;
		public static Artifact GetHeroSlotArtifact(this UserArtifactData data, int heroId, ArtifactKindId kindId) => default;
		public static bool TryGetHeroIdByArtifact(this UserArtifactData data, int artifactId, out int? heroId) {
			heroId = default;
			return default;
		}
		public static IUndoState RemapArtifactBetweenHeroes(this UserArtifactData data, int fromHeroId, int toHeroId) => default;
		public static IUndoState Add(this UserArtifactData data, Artifact artifact) => default;
		public static IUndoState Activate(this UserArtifactData data, int heroId, Artifact artifact) => default;
		public static IUndoState Deactivate(this UserArtifactData data, int heroId, Artifact artifact, bool checkFreeSlots = true) => default;
		public static IUndoState Remove(this UserArtifactData data, int artifactId) => default;
		public static IUndoState Remove(this UserArtifactData data, IEnumerable<int> artifactIds) => default;
		public static IUndoState ProcessHeroRemove(this UserArtifactData data, int heroId) => default;
		public static int GetNextArtifactId(this UserArtifactData data) => default;
		public static int GetInitialLevel(this UserArtifactData data) => default;
		public static int GetFreeInventorySlotsCount(this UserArtifactData data) => default;
		public static int GetFreeInventoryAccessorySlotsCount(this UserArtifactData data) => default;
		public static ArtifactBonus SecondaryBonusOrThrow(this Artifact artifact, PowerUpData material) => default;
		public static bool IsMaxLevel(this Artifact artifact) => default;
		public static Artifact SetPrimaryBonus(this Artifact artifact, StatKindId kindId, BonusValue bonus) => default;
		public static Artifact AddSecBonus(this Artifact artifact, StatKindId kindId, BonusValue bonus) => default;
		public static Artifact LevelUp(this Artifact artifact) => default;
		public static double PrimaryBonusValue(this Artifact artifact) => default;
		public static double PrimaryBonusValueForNextLevel(this Artifact artifact) => default;
		private static double PrimaryBonusValue(this Artifact artifact, int level) => default;
		public static IEnumerable<ArtifactBonus> GetBonusEnumerator(this Artifact artifact) => default;
		public static int CalcPrice(this StaticArtifactData artifactData, ArtifactKindId kind, ArtifactRankId rank, ArtifactRarityId rarity, ArtifactSetKindId setKindId) => default;
		public static int CalcSellPrice(this StaticArtifactData artifactData, int finalPrice, ArtifactRankId rankId) => default;
		public static List<ArtifactSetInfo> GetActiveArtifactSets(this IEnumerable<Artifact> equipedArtifacts, ArtifactRarityId? setRarity = default, ArtifactRankId? rankId = default, int? minLevel = default, ArtifactStatKey statKey = null) => default;
		public static List<ArtifactSetSetup> GetArtifactSetBonuses(this List<ArtifactSetup> equipedArtifacts) => default;
		public static List<ArtifactSetup> ToArtifactSetups(this IEnumerable<Artifact> artifacts) => default;
		public static Artifact AssertNotMaxLevel(this Artifact artifact) => default;
		public static Artifact AssertNotActivated(this Artifact artifact) => default;
		public static Artifact AssertNotDeactivated(this Artifact artifact) => default;
		public static Artifact AssertIsValidMaterial(this Artifact artifact, PowerUpData material) => default;
		public static UserArtifactData AssertEnoughArtifactSlots(this UserArtifactData data, int count) => default;
		public static bool IsEnoughArtifactSlots(this UserArtifactData data, int count = 1) => default;
		public static bool IsEnoughAccessorySlots(this UserArtifactData data, int count = 1) => default;
		public static bool IsAccessorySetKind(this ArtifactSetKindId setKindId) => default;
		public static bool IsArtifactSetKind(this ArtifactSetKindId setKindId) => default;
		public static bool IsAccessory(this ArtifactKindId kindId) => default;
		public static bool IsCommonOrUnknownAccessory(this ArtifactKindId kindId) => default;
		public static bool IsArtifact(this ArtifactKindId kindId) => default;
		public static bool IsUnknown(this ArtifactKindId kindId) => default;
		public static bool IsMax(this ArtifactRankId rankId) => default;
		public static ArtifactStatKindId ToStatKindId(this ArtifactStatKey statKey) => default;
		public static ArtifactStatKey ToStatKey(this ArtifactStatKindId statKindId) => default;
		public static bool IsCommonOrUnknownArtifact(this Artifact self) => default;
		public static bool IsCommonOrUnknownAccessory(this Artifact self) => default;
		public static FixedRandom GetUpgradeRandom(this UserArtifactData data, int artifactId) => default;
	}
}
