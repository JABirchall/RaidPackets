
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using Plarium.GS.Model.Modules.GlobalRatings.Entities;
using SharedModel.Meta.GlobalEvents.Entities;
using SharedModel.Meta.Quests;
using SharedModel.Meta.Tournaments;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.GlobalRatings
{
	[MessagePackObject]
	public class GlobalRatingInfo
	{
		// Fields
		[Json]
		// [Key]
		public GlobalRatingTypeId TypeId;
		[Json]
		// [Key]
		public GlobalRatingTypeId? GlobalTypeId;
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
		public GlobalRatingStatusIds StatusIds;
		[Json]
		// [Key]
		public long Points;
		[Json]
		// [Key]
		public long? Position;
		[Json]
		// [Key]
		public long? GlobalPosition;
		[Json]
		// [Key]
		public bool GlobalRewardTaken;
		[Json]
		// [Key]
		public List<UserPrize> GlobalPositionRewards;
		[Json]
		// [Key]
		public SeenTournamentInfo SeenInfo;
		[Json]
		// [Key]
		public bool AnyRewardAvailable;
		[Json]
		// [Key]
		public int? BracketIndex;
		[Json]
		// [Key]
		public TournamentKindId TournamentKindId;
	
		// Constructors
		public GlobalRatingInfo() {}
	
		// Methods
		public GlobalRatingInfo Clone() => default;
	}
}
