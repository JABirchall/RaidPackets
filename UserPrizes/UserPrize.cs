
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Artifacts;
using SharedModel.Meta.Artifacts.Sets;
using SharedModel.Meta.Artifacts.SharedModel.Meta.Users;
using SharedModel.Meta.Battle.Arena;
using SharedModel.Meta.BlackMarket;
using SharedModel.Meta.Effects;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.UserPrizes
{
	[MessagePackObject]
	public class UserPrize
	{
		// Fields
		[Json]
		// [Key]
		public int? Id;
		[Json]
		// [Key]
		public int Experience;
		[Json]
		// [Key]
		public long ArenaPoints;
		[Json]
		// [Key]
		public long? Arena3X3Points;
		[Json]
		// [Key]
		public int? BattlePassPoints;
		[Json]
		// [Key]
		public Account.Resources Resources;
		[Json]
		// [Key]
		public Dictionary<int, int> HeroParts;
		[Json]
		// [Key]
		public Dictionary<BlackMarketItemId, int> BlackMarketItems;
		[Json]
		// [Key]
		public List<HeroPrize> Heroes;
		[Json]
		// [Key]
		public List<Artifact> Artifacts;
		[Json]
		// [Key]
		public List<UserEffectInfo> Effects;
		[Json]
		// [Key]
		public List<UserAvatarId> Avatars;
		[Json]
		// [Key]
		public List<ArtifactDropSettings> ArtifactDropSettings;
		[Json]
		// [Key]
		public int? ArtifactDropCount;
		[Json]
		// [Key]
		public bool ArtifactDropSettingsProcessed;
		[Json]
		// [Key]
		public bool? NeedToGroupArtifacts;
		[Json]
		// [Key]
		public ArenaLeagueId? RewardedArena3X3LeagueId;
		[Json]
		// [Key]
		public double? Probability;
		[IgnoreMember]
		[JsonSkip]
		private IEnumerable<SetOfArtifacts> _setsOfArtifacts;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public IEnumerable<SetOfArtifacts> SetsOfArtifacts { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool HasExperience { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool HasBattlePassPoints { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool HasResources { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool HasHeroParts { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool HasBmis { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool HasHeroes { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool HasArtifactsOrAccessories { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool HasArtifacts { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool HasAccessory { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool HasEffects { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool HasArtifactDropSettings { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool HasSetOfArtifacts { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool HasAvatars { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public double GemsCount { get => default; }
	
		// Constructors
		public UserPrize() {}
	
		// Methods
		public UserPrize Clone() => default;
		public List<UserPrize> SplitPrizeByArenaTokens() => default;
		public ValueTuple<UserPrize, UserPrize> SplitPrizeByXpBooster() => default;
		public List<UserPrize> SplitPrizeByBmiIds(params BlackMarketItemId[] bmiIds) => default;
		public override int GetHashCode() => default;
		public string ToStringExt() => default;
		public static UserPrize FromExperience(int experience) => default;
		public static UserPrize FromArena3X3Points(long points) => default;
		public static UserPrize FromEnergy(int energy) => default;
		public static UserPrize FromResources(Account.Resources resources) => default;
		public static UserPrize FromGems(double gems) => default;
		public static UserPrize FromHeroParts(int heroTypeId, int count = 5) => default;
		public static UserPrize FromBmi(BlackMarketItemId id, int count = 1) => default;
		public static UserPrize FromBmis(Dictionary<BlackMarketItemId, int> bmis) => default;
		public static UserPrize FromAvatar(UserAvatarId avatarId) => default;
		public static UserPrize FromHero(int heroTypeId, int count = 1, bool? locked = default) => default;
		public static UserPrize FromHeroes(List<HeroPrize> heroPrizes) => default;
		public static UserPrize FromArtifact(ArtifactKindId kindId, ArtifactRankId rankId, ArtifactRarityId rarityId, ArtifactSetKindId setKindId) => default;
		public static UserPrize FromArtifact(Artifact artifact) => default;
		public static UserPrize FromArtifacts(List<Artifact> artifacts) => default;
		public static UserPrize FromBattlePassPoints(int pointsCount) => default;
		private IEnumerable<SetOfArtifacts> ArtifactsAsSetsOrDefault() => default;
		public static UserPrize FromArtifactDropSettings(ArtifactDropSettings dropSettings) => default;
		public UserPrize ForArena3X3LeagueId(ArenaLeagueId leagueId) => default;
		public UserEffectInfo GetEffect(UserEffectTypeId effectTypeId) => default;
		public double GetEffectPower(UserEffectTypeId effectTypeId) => default;
		private SetOfArtifacts AllArtifactsAsSingleSet() => default;
		private IEnumerable<SetOfArtifacts> ArtifactSets() => default;
		private IEnumerable<SetOfArtifacts> AccessorySets() => default;
		private static SetOfArtifacts AsSet(List<Artifact> artifacts) => default;
		public override bool Equals(object obj) => default;
		protected bool Equals(UserPrize other) => default;
	}
}
