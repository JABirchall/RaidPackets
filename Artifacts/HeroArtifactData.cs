
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Artifacts
{
	[MessagePackObject]
	public class HeroArtifactData
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<ArtifactKindId, int> ArtifactIdByKind;
	
		// Constructors
		public HeroArtifactData() {}
	}
}
