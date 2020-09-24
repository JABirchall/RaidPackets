
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.GlobalEvents.Entities
{
	[MessagePackObject]
	public class BracketDto
	{
		// Fields
		[Json]
		// [Key]
		public int MinLevel;
		[Json]
		// [Key]
		public int MaxLevel;
		[Json]
		// [Key]
		public int Size;
		[Json]
		// [Key]
		public List<GlobalEventRewardItem> ProgressionReward;
		[Json]
		// [Key]
		public List<UserPrize> PositionRewards;
	
		// Constructors
		public BracketDto() {}
	}
}
