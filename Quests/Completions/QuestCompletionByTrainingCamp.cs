
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.TrainingCamp;



namespace SharedModel.Meta.Quests.Completions
{
	[MessagePackObject]
	public class QuestCompletionByTrainingCamp
	{
		// Fields
		[Json]
		// [Key]
		public int CountRequired;
		[Json]
		// [Key]
		public int CountCollected;
	
		// Constructors
		public QuestCompletionByTrainingCamp() {}
	
		// Methods
		public bool IsCompleted(UserTrainingCampData trainingCampData) => default;
		public QuestCompletionProgress CalcProgress(UserTrainingCampData trainingCampData) => default;
		public QuestCompletionByTrainingCamp Clone() => default;
	}
}
