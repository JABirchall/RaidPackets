
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Numerics;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Battle.AutoBattle;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta
{
	[MessagePackObject]
	public class StaticGameplayData
	{
		// Fields
		[Json]
		// [Key]
		public StaticUserLevelData LevelData;
		[Json]
		// [Key]
		public List<UserPrize> BundlesLoadingRewards;
		[Json]
		// [Key]
		public int MaxTokens;
		[Json]
		// [Key]
		public int MaxArena3X3Tokens;
		[Json]
		// [Key]
		public int MaxForgeResources;
		[Json]
		// [Key]
		public AutoBattleSettings AutoBattleSettings;
		[Json]
		// [Key]
		public UserPrize UpdateReward;
		[Json]
		// [Key]
		public Dictionary<UserAvatarGroupId, List<UserAvatarId>> UserAvatars;
		[Json]
		// [Key]
		public Fixed StaminaToTurn;
		[Json]
		// [Key]
		public Fixed StaminaByTick;
		[Json]
		// [Key]
		public Fixed HealOnStartRound;
		[Json]
		// [Key]
		public Fixed ElementDisadvantageCoef;
		[Json]
		// [Key]
		public Fixed CrushingHitCoef;
		[Json]
		// [Key]
		public Fixed GlancingHitCoef;
		[Json]
		// [Key]
		public Fixed CriticalHealCoef;
		[Json]
		// [Key]
		public Fixed CriticalHitChance;
		[Json]
		// [Key]
		public Fixed CrushingHitChance;
		[Json]
		// [Key]
		public Fixed GlancingHitChance;
		[Json]
		// [Key]
		public Fixed CriticalHitChanceAdvantage;
		[Json]
		// [Key]
		public int MaxAppliedBuffEffects;
		[Json]
		// [Key]
		public int MaxAppliedDebuffEffects;
		[Json]
		// [Key]
		public Fixed HpDestructionFromDamagePercent;
		[Json]
		// [Key]
		public Fixed MaxPossibleHpDestructionPercent;
		[Json]
		// [Key]
		public Fixed MaxPossibleHpDestructionPerSkillPercent;
		[Json]
		// [Key]
		public Fixed CounterattackModifier;
		[IgnoreMember]
		[JsonSkip]
		private List<UserAvatarId> _avatarIds;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public List<UserAvatarId> AvatarIds { get => default; }
	
		// Constructors
		public StaticGameplayData() {}
	
		// Methods
		public int GetEnergyLimit(int level) => default;
	}
}
