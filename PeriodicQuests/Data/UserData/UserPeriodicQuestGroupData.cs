
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.PeriodicQuests.Data;



namespace SharedModel.Meta.PeriodicQuests.Data.UserData
{
	[MessagePackObject]
	public class UserPeriodicQuestGroupData
	{
		// Fields
		[Json]
		// [Key]
		public PeriodicQuestGroupId GroupId;
		[Json]
		// [Key]
		public PeriodicQuestsPackId QuestsPackId;
		[Json]
		// [Key]
		public PeriodicQuestsPackId? LastQuestsPackId;
		[Json]
		// [Key]
		public PeriodicQuestsCycleId CycleId;
		[Json]
		// [Key]
		public PeriodicQuestsCycleId? LastCycleId;
		[Json]
		// [Key]
		public DateTime StartTime;
		[Json]
		// [Key]
		public TimeSpan LifeTime;
		[Json]
		// [Key]
		public DateTime DeadLine;
		[Json]
		// [Key]
		public List<UserPeriodicQuestStateData> PeriodicQuestsData;
	
		// Constructors
		public UserPeriodicQuestGroupData() {}
	
		// Methods
		public static UserPeriodicQuestGroupData Create(PeriodicQuestGroupId groupId) => default;
	}
}
