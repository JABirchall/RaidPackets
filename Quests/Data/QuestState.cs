
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.AdvancedDaily;
using SharedModel.Meta.GlobalEvents.Entities;
using SharedModel.Meta.PeriodicQuests.Data;
using SharedModel.Meta.Quests;
using SharedModel.Meta.Quests.Completions;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Quests.Data
{
	[MessagePackObject]
	public class QuestState
	{
		// Fields
		[Json]
		// [Key]
		public int QuestId;
		[Json]
		// [Key]
		public int PrototypeId;
		[Json]
		// [Key]
		public int? Weight;
		[Json]
		// [Key]
		public bool IsRead;
		[Json]
		// [Key]
		public bool IsForced;
		[Json]
		// [Key]
		public bool? SkipReward;
		[Json]
		// [Key]
		public bool PrizeGiven;
		[Json]
		// [Key]
		public QuestStateId StateId;
		[Json]
		// [Key]
		public DateTime TimeOpened;
		[Json]
		// [Key]
		public DateTime? TimeStarted;
		[Json]
		// [Key]
		public DateTime? TimeDeadline;
		[Json]
		// [Key]
		public DateTime? TimeCompleted;
		[Json]
		// [Key]
		public DateTime? TakePrizeDeadline;
		[Json]
		// [Key]
		public List<QuestCompletion> Completions;
		[Json]
		// [Key]
		public List<UserPrize> Prizes;
		[Json]
		// [Key]
		public UserPrize Prize;
		[Json]
		// [Key]
		public RecommendedQuestGroupId? RecommendedQuestGroupId;
		[Json]
		// [Key]
		public PeriodicQuestGroupId? PeriodicQuestGroupId;
		[Json]
		// [Key]
		public PeriodicQuestsPackId? PeriodicQuestsPackId;
		[Json]
		// [Key]
		public int? BattlePassId;
		[Json]
		// [Key]
		public AdvancedDailyTypeId? AdvancedDailyTypeId;
		[Json]
		// [Key]
		public List<int> GlobalEventTakenRewardIds;
		[Json]
		// [Key]
		public bool? CanTakeGlobalEventReward;
		[IgnoreMember]
		[JsonSkip]
		public bool? PeriodicQuestClosedOnRefresh;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public int GlobalEventTotalPoints { get => default; }
	
		// Constructors
		public QuestState() {}
	
		// Methods
		public override int GetHashCode() => default;
		public void SetGlobalEventRewardAvailability(GlobalEventQuestInfo globalEventInfo) {}
		public bool CanCloseGlobalEvent(DateTime now) => default;
	}
}
