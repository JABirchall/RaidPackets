
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
	public class SecArtifactBonusInfo
	{
		// Fields
		[Json]
		// [Key]
		public ArtifactStatKey StatKey;
		[Json]
		// [Key]
		public Dictionary<ArtifactRankId, SecArtifactBonusValue> ValueByRankId;
		[Json]
		// [Key]
		public List<ArtifactKindId> ApplicableKindIds;
	
		// Constructors
		public SecArtifactBonusInfo() {}
	}
}
