
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.PeriodicQuests.Data;



namespace SharedModel.Meta.PeriodicQuests
{
	[MessagePackObject]
	public class QuestCompletionPeriodic
	{
		// Fields
		[Json]
		// [Key]
		public PeriodicQuestData QuestData;
		[Json]
		// [Key]
		public long CurrentPoints;
	
		// Constructors
		public QuestCompletionPeriodic() {}
		public QuestCompletionPeriodic(PeriodicQuestData questData) {}
	
		// Methods
		public QuestCompletionPeriodic Clone() => default;
		public bool IsCompleted() => default;
		public void IncrementPoints(long point = 1) {}
	}
}
