
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Quests;



namespace SharedModel.Meta.Quests.Completions
{
	[MessagePackObject]
	public class QuestCompletionByClient
	{
		// Fields
		[Json]
		// [Key]
		public int CountRequired;
		[Json]
		// [Key]
		public int CountCollected;
		[Json]
		// [Key]
		public QuestCompletionByClientCode Code;
		[Json]
		// [Key]
		public long Param;
	
		// Constructors
		public QuestCompletionByClient() {}
	
		// Methods
		public bool IsCompleted() => default;
		public QuestCompletionByClient Clone() => default;
	}
}
