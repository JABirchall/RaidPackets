
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Quests.Completions
{
	[MessagePackObject]
	public class QuestCompletionByFuse
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
		public int? HeroTypeId;
		[Json]
		// [Key]
		public ResourceTypeId? ResourceTypeId;
	
		// Constructors
		public QuestCompletionByFuse() {}
	
		// Methods
		public bool IsCompleted(UserHeroData readData) => default;
		public QuestCompletionProgress CalcProgress(UserHeroData heroData) => default;
		public QuestCompletionByFuse Clone() => default;
	}
}
