
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Math;



namespace SharedModel.Meta.Artifacts
{
	[MessagePackObject]
	public class UserArtifactData
	{
		// Fields
		[Json]
		// [Key]
		public int NextArtifactId;
		[Json]
		// [Key]
		public List<FixedRandom> UpgradeRandoms;
		[Json]
		// [Key]
		public List<Artifact> Artifacts;
		[Json]
		// [Key]
		public Dictionary<int, HeroArtifactData> ArtifactDataByHeroId;
	
		// Constructors
		public UserArtifactData() {}
	}
}
