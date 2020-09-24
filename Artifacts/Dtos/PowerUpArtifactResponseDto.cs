
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
	public class PowerUpArtifactResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public Artifact Artifact;
		[Json]
		// [Key]
		public double Value;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public bool WasPowerUpped { get => default; }
	
		// Constructors
		public PowerUpArtifactResponseDto() {}
	}
}
