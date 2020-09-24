
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Quests.Data
{
	[MessagePackObject]
	public class UserQuestAdvancedDailyData
	{
		// Fields
		[Json]
		// [Key]
		public int CompletedThisPeriodDailyQuests;
		[Json]
		// [Key]
		public bool Seen;
	
		// Constructors
		public UserQuestAdvancedDailyData() {}
	}
}
