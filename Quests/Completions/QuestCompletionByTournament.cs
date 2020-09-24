
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.GlobalRatings;
using SharedModel.Meta.Quests.Data;



namespace SharedModel.Meta.Quests.Completions
{
	[MessagePackObject]
	public class QuestCompletionByTournament
	{
		// Fields
		[Json]
		// [Key]
		public GlobalRatingInfo GlobalRatingInfo;
		[Json]
		// [Key]
		public QuestTournamentProgress Progress;
	
		// Constructors
		public QuestCompletionByTournament() {}
	
		// Methods
		public QuestCompletionByTournament Clone() => default;
		public bool IsCompleted() => default;
	}
}
