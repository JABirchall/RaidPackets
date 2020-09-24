
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Quests.AdvancedDailyQuests
{
	[MessagePackObject]
	public class AdvancedDailyQuestData
	{
		// Fields
		[Json]
		// [Key]
		public List<int> MilestoneTotalSteps;
		[Json]
		// [Key]
		public int CompleteAllDailyQuestsPrototypeId;
	
		// Constructors
		public AdvancedDailyQuestData() {}
	}
}
