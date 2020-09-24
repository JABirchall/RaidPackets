
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Artifacts;



namespace SharedModel.Meta.Artifacts.Dtos
{
	[MessagePackObject]
	public class UpgradeArtifactResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public Artifact Artifact;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public bool WasUpgraded { get => default; }
	
		// Constructors
		public UpgradeArtifactResponseDto() {}
	}
}
