
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Effects;
using SharedModel.Meta.Artifacts;
using SharedModel.Meta.Artifacts.Bonuses;
using SharedModel.Meta.Artifacts.Sets;



namespace SharedModel.Meta.Quests.Completions
{
	[MessagePackObject]
	public class ArtifactLootInfo
	{
		// Fields
		[Json]
		// [Key]
		public bool RandomArtifact;
		[Json]
		// [Key]
		public ArtifactStatKey ArtifactStatKey;
		[Json]
		// [Key]
		public ArtifactKindId? ArtifactKindId;
		[Json]
		// [Key]
		public ArtifactRankId? ArtifactRankId;
		[Json]
		// [Key]
		public ArtifactRarityId? ArtifactRarityId;
		[Json]
		// [Key]
		public ArtifactSetKindId? ArtifactSetKindId;
		[Json]
		// [Key]
		public ArtifactLootTypeId? LootTypeId;
		[Json]
		// [Key]
		public StatKindId? StatKind;
		[Json]
		// [Key]
		public bool ShouldBeDifferent;
		[Json]
		// [Key]
		public bool? AlreadyGained;
	
		// Constructors
		public ArtifactLootInfo() {}
	
		// Methods
		public ArtifactLootInfo Clone() => default;
	}
}
