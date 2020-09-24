
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Attributes;
using SharedModel.Meta.Tournaments;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Account
{
	[MessagePackObject]
	// [RemovedJson]
	public class UserAccount
	{
		// Fields
		[Json]
		// [Key]
		public bool IsAdmin;
		[Json]
		// [Key]
		public ModeratorRole ModeratorRole;
		[Json]
		// [Key]
		public int Level;
		[Json]
		// [Key]
		public long Experience;
		[Json]
		// [Key]
		public long FullExperience;
		[Json]
		// [Key]
		public long CurrentLevelInGameTimeMs;
		[Json]
		// [Key]
		public IdfaAgreementResult? IdfaAgreementResult;
		[Json]
		// [Key]
		public Resources Resources;
		[Json]
		// [Key]
		public Resources ResourcesGained;
		[Json]
		// [Key]
		public Resources ResourcesSpent;
		[Json]
		// [Key]
		public double GemsAdded;
		[Json]
		// [Key]
		public double GemsSpent;
		[Json]
		// [Key]
		public double FreeDailyTokensAdded;
		[Json]
		// [Key]
		public InfluencerInfo InfluencerInfo;
		[Json]
		// [Key]
		public Dictionary<int, UserPrize> MilestoneRewards;
		[Json]
		// [Key]
		public List<int> CollectedLoadingPrizeIndices;
		[Json]
		// [Key]
		public DateTime TicketsLastRefreshTime;
		[Json]
		// [Key]
		public DateTime DailyArena3X3TokensLastRefreshTime;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public bool IsModerator { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool IsChatModerator { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool IsGameModerator { get => default; }
	
		// Constructors
		public UserAccount() {}
	}
}
