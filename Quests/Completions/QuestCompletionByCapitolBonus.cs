
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Effects;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.Village;



namespace SharedModel.Meta.Quests.Completions
{
	[MessagePackObject]
	public class QuestCompletionByCapitolBonus
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
		public Element? ExceptElement;
		[Json]
		// [Key]
		public StatKindId? StatKindId;
		[Json]
		// [Key]
		public int? Level;
	
		// Constructors
		public QuestCompletionByCapitolBonus() {}
	
		// Methods
		public bool IsDone(UserVillageData villageData) => default;
		public bool IsCompleted(UserVillageData villageData) => default;
		public QuestCompletionProgress CalcProgress(UserVillageData villageData) => default;
		public QuestCompletionByCapitolBonus Clone() => default;
	}
}
