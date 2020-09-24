
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Artifacts;
using SharedModel.Meta.Artifacts.Sets;



namespace SharedModel.Meta.Quests.Completions
{
	[MessagePackObject]
	public class QuestCompletionByForge
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
		public ArtifactSetKindId? ArtifactSetKindId;
		[Json]
		// [Key]
		public ArtifactRarityId? ArtifactRarityId;
	
		// Constructors
		public QuestCompletionByForge() {}
	
		// Methods
		public QuestCompletionByForge Clone() => default;
	}
}
