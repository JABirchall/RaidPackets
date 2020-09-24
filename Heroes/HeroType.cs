
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.AI.Utility;
using SharedModel.Battle.Core.Setup;
using SharedModel.Common.Hashing;
using SharedModel.Common.Localization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Artifacts;
using SharedModel.Meta.Skills;



namespace SharedModel.Meta.Heroes
{
	[MessagePackObject]
	public class HeroType : IHashable
	{
		// Fields
		public const string AvatarUrlBasePath = "HeroAvatars/";
		public const string QuarantineDefaultModelUrl = "0003_Knight_1040_silhouette";
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		// [SharedLocalization]
		public SharedLTextKey Name;
		[Json]
		// [Key]
		public string AvatarName;
		[Json]
		// [Key]
		public string ModelName;
		[Json]
		// [Key]
		public Element Element;
		[Json]
		// [Key]
		public HeroRole Role;
		[Json]
		// [Key]
		public HeroFraction Fraction;
		[Json]
		// [Key]
		public HeroRarity Rarity;
		[Json]
		// [Key]
		public Account.Resources AwakenMaterials;
		[Json]
		// [Key]
		public BattleStats BaseStats;
		[Json]
		// [Key]
		public List<int> SkillTypeIds;
		[Json]
		// [Key]
		public LeaderSkill LeaderSkill;
		[Json]
		// [Key]
		public BossInfo BossInfoOld;
		[Json]
		// [Key]
		public BossData BossInfoNew;
		[Json]
		// [Key]
		public double SummonWeight;
		[Json]
		// [Key]
		public bool IsLocationOnly;
		[Json]
		// [Key]
		public ReadyStatus Status;
		[Json]
		// [Key]
		public Brain Brain;
		[Json]
		// [Key]
		public List<ArtifactSuggestion> ArtifactSuggestions;
		[IgnoreMember]
		[JsonSkip]
		private bool? _isAwakable;
		[IgnoreMember]
		[JsonSkip]
		private HeroType _maxAwakenedType;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<ArtifactKindId, List<ArtifactSuggestion>> _artSuggestionsByKindId;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public BossInfo BossInfo { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public BossData BossData { get => default; set {} }
		[IgnoreMember]
		[JsonSkip]
		public bool IsChecked { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool OnQuarantine { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool IsAwakable { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool IsMaxAwakened { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool IsAwakeSupported { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public int AwakeLevel { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public int AwakenHeroId { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public int UnAwakenHeroId { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public int BaseId { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public HeroType MaxAwakenedType { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public string AvatarUrl { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public string ModelUrl { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool IsBoss { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<ArtifactKindId, List<ArtifactSuggestion>> ArtSuggestionsByKindId { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool IsBaseType { get => default; }
	
		// Constructors
		public HeroType() {}
	
		// Methods
		private HeroType GetMaxAwakenedHeroType(HeroType heroType) => default;
		public static bool AreOfSameFamily(int heroTypeId1, int heroTypeId2) => default;
		public static int GetBaseTypeId(int heroTypeId) => default;
		public static int GetAwakeLevel(int heroTypeId) => default;
		public bool IsOfSameFamilyWith(HeroType heroType) => default;
		public void ResetAwakeableState() {}
		public void Validate(HeroSlotSetup setup) {}
		public override bool Equals(object obj) => default;
		protected bool Equals(HeroType other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
		public HeroType Clone() => default;
		public override string ToString() => default;
	}
}
