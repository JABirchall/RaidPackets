
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Quests.Data;



namespace SharedModel.Meta.Quests.Completions
{
	[MessagePackObject]
	public class QuestCompletionBySoloEvent
	{
		// Fields
		[Json]
		// [Key]
		public List<GlobalEventActionProgress> EventsProgress;
	
		// Constructors
		public QuestCompletionBySoloEvent() {}
	
		// Methods
		public QuestCompletionBySoloEvent Clone() => default;
		public bool IsCompleted() => default;
	}
}
