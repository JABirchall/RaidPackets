
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Quests.Completions
{
	[MessagePackObject]
	public class QuestCompletionByMastery
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
		public bool? ByMasteryPoints;
		[Json]
		// [Key]
		public int? RowNumber;
		[Json]
		// [Key]
		public int MasteriesCount;
		[Json]
		// [Key]
		public List<int> HeroIds;
	
		// Constructors
		public QuestCompletionByMastery() {}
	
		// Methods
		public bool IsCompleted(UserHeroData readData) => default;
		public QuestCompletionProgress CalcProgress(UserHeroData heroData) => default;
		public QuestCompletionByMastery Clone() => default;
	}
}
