
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Quests.Completions
{
	public class QuestCompletionProgress
	{
		// Fields
		public static readonly QuestCompletionProgress Uncompleted;
		public static readonly QuestCompletionProgress Completed;
		public readonly int StepsCompleted;
		public readonly int TotalSteps;
	
		// Properties
		public bool IsCompleted { get => default; }
	
		// Constructors
		public QuestCompletionProgress() {} // Dummy constructor
		public QuestCompletionProgress(int stepsCompleted, int totalSteps) {}
		static QuestCompletionProgress() {}
	}
}
