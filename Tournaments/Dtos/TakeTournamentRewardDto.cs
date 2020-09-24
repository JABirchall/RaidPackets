
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Tournaments.Dtos
{
	[MessagePackObject]
	public class TakeTournamentRewardDto
	{
		// Fields
		[Json]
		// [Key]
		public List<int> RewardIds;
		[Json]
		// [Key]
		public bool TakePositionReward;
		[Json]
		// [Key]
		public bool TakeGlobalPositionReward;
		[Json]
		// [Key]
		public int QuestStateId;
	
		// Constructors
		public TakeTournamentRewardDto() {}
	}
}
