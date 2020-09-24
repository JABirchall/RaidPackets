
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Alliances;



namespace SharedModel.Meta.Quests.Completions
{
	[MessagePackObject]
	public class QuestCompletionByAllianceActivity
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
		public bool? EarnStars;
	
		// Constructors
		public QuestCompletionByAllianceActivity() {}
	
		// Methods
		public bool IsCompleted(UserAllianceData allianceData) => default;
		public QuestCompletionProgress CalcProgress(UserAllianceData allianceData) => default;
		public QuestCompletionByAllianceActivity Clone() => default;
	}
}
