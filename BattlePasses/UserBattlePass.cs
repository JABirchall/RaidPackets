
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.BattlePasses
{
	[MessagePackObject]
	public class UserBattlePass
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public int EarnedPoints;
		[Json]
		// [Key]
		public BattlePassStatus Status;
		[Json]
		// [Key]
		public BattlePassTypeId TypeId;
		[Json]
		// [Key]
		public Dictionary<BattlePassTypeId, List<int>> CollectedLevelsByTypeId;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public List<BattlePassLevel> Levels { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public List<BattlePassLevel> EarnedLevels { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool Completed { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public int Level { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool IsMaxLevel { get => default; }
	
		// Constructors
		public UserBattlePass() {}
	}
}
