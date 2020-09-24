
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
	public class QuestCompletionByAccount
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
		public bool? CollectSilver;
	
		// Constructors
		public QuestCompletionByAccount() {}
	
		// Methods
		public bool IsCompleted(UserAccount account) => default;
		public QuestCompletionProgress CalcProgress(UserAccount account) => default;
		public QuestCompletionByAccount Clone() => default;
	}
}
