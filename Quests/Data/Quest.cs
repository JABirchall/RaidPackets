
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Attributes;
using SharedModel.Common.Localization;
using SharedModel.Meta.AdvancedDaily;
using SharedModel.Meta.BattlePasses.Quest;
using SharedModel.Meta.GlobalEvents.Entities;
using SharedModel.Meta.Quests;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Quests.Data
{
	[MessagePackObject]
	// [RemovedJson]
	public class Quest
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public int PrototypeId;
		[Json]
		// [Key]
		public QuestCategoryId CategoryId;
		[Json]
		// [Key]
		public int Weight;
		[Json]
		// [Key]
		public List<UserPrize> Prizes;
		[Json]
		// [Key]
		public UserPrize Prize;
		[Json]
		// [Key]
		public bool AddPrizeToInbox;
		[Json]
		// [Key]
		public string Icon;
		[Json]
		// [Key]
		public string Picture;
		[Json]
		// [Key]
		public string Picture2;
		[Json]
		// [Key]
		// [SharedLocalization]
		public SharedLTextKey Name;
		[Json]
		// [Key]
		// [SharedLocalization]
		public SharedLTextKey Description;
		[Json]
		// [Key]
		public SharedLTextKey CallToActionText;
		[Json]
		// [Key]
		public SharedLTextKey[] TextSteps;
		[Json]
		// [Key]
		public SharedLTextKey IntroText;
		[Json]
		// [Key]
		public SharedLTextKey IntroShortText;
		[Json]
		// [Key]
		public SharedLTextKey OutroText;
		[Json]
		// [Key]
		public SharedLTextKey OutroText2;
		[Json]
		// [Key]
		public ChallengeQuestCategoryId? ChallengeQuestCategoryId;
		[Json]
		// [Key]
		public int? ChallengeQuestPart;
		[Json]
		// [Key]
		public int? ChallengeQuestIndex;
		[Json]
		// [Key]
		public RecommendedQuestCategoryId? RecommendedQuestCategoryId;
		[Json]
		// [Key]
		public RecommendedQuestGroupId? RecommendedQuestGroupId;
		[Json]
		// [Key]
		public BattlePassQuestTypeId? BattlePassQuestTypeId;
		[Json]
		// [Key]
		public AdvancedDailyTypeId? AdvancedDailyQuestTypeId;
		[Json]
		// [Key]
		public GlobalEventQuestInfo GlobalEventInfo;
		[Json]
		// [Key]
		public bool? ForceClose;
		[Json]
		// [Key]
		public bool? WithholdPrize;
	
		// Constructors
		public Quest() {}
	
		// Methods
		public Quest Clone() => default;
	}
}
