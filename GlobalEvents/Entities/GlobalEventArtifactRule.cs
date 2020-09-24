
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Artifacts;
using SharedModel.Meta.Artifacts.Sets;



namespace SharedModel.Meta.GlobalEvents.Entities
{
	[MessagePackObject]
	public class GlobalEventArtifactRule
	{
		// Fields
		[Json]
		// [Key]
		public ArtifactKindId? Kind;
		[Json]
		// [Key]
		public ArtifactSetKindId? SetKind;
		[Json]
		// [Key]
		public ArtifactRankId? Rank;
		[Json]
		// [Key]
		public ArtifactRarityId? Rarity;
		[Json]
		// [Key]
		public int? Level;
	
		// Constructors
		public GlobalEventArtifactRule() {}
	
		// Methods
		public bool Satisfies(Artifact artifact) => default;
		public GlobalEventArtifactRule Clone() => default;
	}
}
