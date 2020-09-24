
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Quests.Completions
{
	[MessagePackObject]
	public class QuestCompletionByQuest
	{
		// Fields
		[Json]
		// [Key]
		public List<int> RequiredPrototypeIds;
		[Json]
		// [Key]
		public List<int> CompletedPrototypeIds;
	
		// Constructors
		public QuestCompletionByQuest() {}
	
		// Methods
		public bool IsCompleted() => default;
		public QuestCompletionByQuest Clone() => default;
	}
}
