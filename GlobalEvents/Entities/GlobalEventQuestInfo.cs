
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Quests;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.GlobalEvents.Entities
{
	[MessagePackObject]
	public class GlobalEventQuestInfo
	{
		// Fields
		[Json]
		// [Key]
		public int MaxPointsPerDay;
		[Json]
		// [Key]
		public int? GlobalRatingSize;
		[Json]
		// [Key]
		public GlobalEventConditionRule ConditionRule;
		[Json]
		// [Key]
		public Dictionary<GlobalEventAction, List<GlobalEventRule>> Rules;
		[Json]
		// [Key]
		public GlobalEventReward Reward;
		[Json]
		// [Key]
		public List<BracketDto> Brackets;
		[Json]
		// [Key]
		public bool HasGlobalRating;
		[Json]
		// [Key]
		public TournamentKindId? TournamentKindId;
		[Json]
		// [Key]
		public List<UserPrize> GlobalPositionRewards;
	
		// Constructors
		public GlobalEventQuestInfo() {}
	}
}
