
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;
using SharedModel.Common.Localization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Masteries;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Stages
{
	[MessagePackObject]
	public class Stage : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		// [SharedLocalization]
		public SharedLTextKey Name;
		[Json]
		// [Key]
		public string SceneName;
		[Json]
		// [Key]
		public int UserHeroesCount;
		[Json]
		// [Key]
		public List<StageHeroesFormation> Formations;
		[Json]
		// [Key]
		public Account.Resources RevivePrice;
		[Json]
		// [Key]
		public List<BattleStatsModifier> Modifiers;
		[Json]
		// [Key]
		public int RewardHeroXp;
		[Json]
		// [Key]
		public List<MasteryRewardInfo> MasteryRewards;
		[Json]
		// [Key]
		public List<FlexibleRewardInfo> Rewards;
		[Json]
		// [Key]
		public UserPrize FirstTimeReward;
		[Json]
		// [Key]
		public FlexibleReward Reward;
		[Json]
		// [Key]
		public StageStartCondition StartCondition;
		[IgnoreMember]
		[JsonSkip]
		public bool HasBoss;
		[IgnoreMember]
		[JsonSkip]
		private Area _area;
		[IgnoreMember]
		[JsonSkip]
		private Region _region;
		[IgnoreMember]
		[JsonSkip]
		private DifficultyId? _difficulty;
		[IgnoreMember]
		[JsonSkip]
		private int? _number;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<MasteryPointType, MasteryRewardInfo> _masteryRewardsByType;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public Area Area { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public Region Region { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public DifficultyId Difficulty { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public int Number { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool HasTemporaryRewards { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool HasMasteryReward { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<MasteryPointType, MasteryRewardInfo> MasteryRewardsByType { get => default; }
	
		// Constructors
		public Stage() {}
	
		// Methods
		private int GetNumber() => default;
		public Account.Resources GetStartPrice(bool isAutoBattle) => default;
		public override bool Equals(object obj) => default;
		protected bool Equals(Stage other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
	}
}
