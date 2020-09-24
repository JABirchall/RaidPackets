
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Quests;



namespace SharedModel.Meta.Quests.RecommendedQuests
{
	[MessagePackObject]
	public class UserRecommendedQuestData
	{
		// Fields
		[Json]
		// [Key]
		public List<int> CompletedPrototypeIds;
		[Json]
		// [Key]
		public int LastQuestWeight;
		[Json]
		// [Key]
		public int LastCompletedStageId;
		[Json]
		// [Key]
		public RecommendedQuestGroupId UserGroup;
		[Json]
		// [Key]
		public RecommendedQuestGroupId? LastCompletedGroup;
		[Json]
		// [Key]
		public RecommendedQuestsVersion QuestsVersion;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public bool FirstGroupSkippedAndRewardWasNotClaimed { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool IsInAlreadyCompletedGroup { get => default; }
	
		// Constructors
		public UserRecommendedQuestData() {}
	
		// Methods
		public RecommendedQuestGroupId GetNextGroup() => default;
	}
}
