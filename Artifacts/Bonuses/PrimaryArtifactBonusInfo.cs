
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Artifacts;



namespace SharedModel.Meta.Artifacts.Bonuses
{
	[MessagePackObject]
	public class PrimaryArtifactBonusInfo
	{
		// Fields
		[Json]
		// [Key]
		public ArtifactStatKey StatKey;
		[Json]
		// [Key]
		public Dictionary<ArtifactRankId, double[]> ValuesByLevelByRankId;
		[Json]
		// [Key]
		public List<ArtifactKindId> ApplicableKindIds;
	
		// Constructors
		public PrimaryArtifactBonusInfo() {}
	}
}
