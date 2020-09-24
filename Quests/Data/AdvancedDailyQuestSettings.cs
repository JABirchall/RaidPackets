
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Quests.Data
{
	[MessagePackObject]
	public class AdvancedDailyQuestSettings
	{
		// Fields
		[Json]
		// [Key]
		public bool Enabled;
		[Json]
		// [Key]
		public int MinUserLevel;
		[Json]
		// [Key]
		public List<int> DisabledQuestPrototypeIds;
	
		// Constructors
		public AdvancedDailyQuestSettings() {}
	}
}
