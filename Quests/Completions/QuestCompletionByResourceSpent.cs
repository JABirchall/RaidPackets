
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.Quests.Completions
{
	[MessagePackObject]
	public class QuestCompletionByResourceSpent
	{
		// Fields
		[Json]
		// [Key]
		public ResourceTypeId? TypeId;
		[Json]
		// [Key]
		public ResourceKindId? KindId;
		[Json]
		// [Key]
		public int CountRequired;
		[Json]
		// [Key]
		public int CountCollected;
	
		// Constructors
		public QuestCompletionByResourceSpent() {}
	
		// Methods
		public QuestCompletionProgress CalcProgress() => default;
		public QuestCompletionByResourceSpent Clone() => default;
	}
}
