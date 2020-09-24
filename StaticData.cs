
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Core.Skill.EffectContexts;
using SharedModel.Battle.Effects;
using SharedModel.Common.ExpressionParser;
using SharedModel.Meta.AbTests;
using SharedModel.Meta.Alliances;
using SharedModel.Meta.AmazonIntegration;
using SharedModel.Meta.Artifacts;
using SharedModel.Meta.AutoOpen;
using SharedModel.Meta.Battle.Arena;
using SharedModel.Meta.Battle.Arena.Dtos;
using SharedModel.Meta.BattlePasses;
using SharedModel.Meta.BlackMarket;
using SharedModel.Meta.DailyRewards.Data;
using SharedModel.Meta.DailyUpdates;
using SharedModel.Meta.Forge.Static;
using SharedModel.Meta.Fuse.Static;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.Inbox;
using SharedModel.Meta.LoyaltyProgram.Data;
using SharedModel.Meta.MagicShop;
using SharedModel.Meta.Masteries;
using SharedModel.Meta.Notifications;
using SharedModel.Meta.Quests.Data;
using SharedModel.Meta.ReferralProgram.Data;
using SharedModel.Meta.SessionChests;
using SharedModel.Meta.Shards;
using SharedModel.Meta.Skills;
using SharedModel.Meta.Stages;
using SharedModel.Meta.TrainingCamp;
using SharedModel.Meta.Village;



namespace SharedModel.Meta
{
	[MessagePackObject]
	public class StaticData
	{
		// Fields
		[Json]
		// [Key]
		public StaticHeroData HeroData;
		[Json]
		// [Key]
		public StaticSkillData SkillData;
		[Json]
		// [Key]
		public StaticEffectData EffectData;
		[Json]
		// [Key]
		public StaticArtifactData ArtifactData;
		[Json]
		// [Key]
		public StaticGameplayData GameplayData;
		[Json]
		// [Key]
		public StaticStageData StageData;
		[Json]
		// [Key]
		public StaticBlackMarketData BlackMarketData;
		[Json]
		// [Key]
		public StaticFuseData FuseData;
		[Json]
		// [Key]
		public StaticForgeData ForgeData;
		[Json]
		// [Key]
		public StaticVillageData VillageData;
		[Json]
		// [Key]
		public StaticMagicShopData MagicShopData;
		[Json]
		// [Key]
		public StaticShardData ShardData;
		[Json]
		// [Key]
		public StaticTrainingCampData TrainingCampData;
		[Json]
		// [Key]
		public StaticQuestData QuestData;
		[Json]
		// [Key]
		public StaticStandardArenaData ArenaData;
		[Json]
		// [Key]
		public StaticArena3X3Data Arena3X3Data;
		[Json]
		// [Key]
		public StaticDailyRewardData DailyRewardData;
		[Json]
		// [Key]
		public StaticInboxData InboxData;
		[Json]
		// [Key]
		public StaticAbTestData AbTestData;
		[Json]
		// [Key]
		public StaticSessionChestData SessionChestData;
		[Json]
		// [Key]
		public StaticMasteryData MasteryData;
		[Json]
		// [Key]
		public StaticLoyaltyProgramData LoyaltyProgramData;
		[Json]
		// [Key]
		public StaticAllianceData AllianceData;
		[Json]
		// [Key]
		public StaticNotificationData NotificationData;
		[Json]
		// [Key]
		public StaticDailyUpdateData DailyUpdateData;
		[Json]
		// [Key]
		public StaticReferralProgramData ReferralProgramData;
		[Json]
		// [Key]
		public StaticAmazonIntegrationData AmazonIntegrationData;
		[Json]
		// [Key]
		public StaticBattlePassData BattlePassData;
		[Json]
		// [Key]
		public StaticAutoOpenGroupsData AutoOpenGroupsData;
		[Json]
		// [Key]
		public string Revision;
	
		// Constructors
		public StaticData() {}
	
		// Methods
		public void Cache(ExpressionBuilder<EffectContext> parser) {}
	}
}
