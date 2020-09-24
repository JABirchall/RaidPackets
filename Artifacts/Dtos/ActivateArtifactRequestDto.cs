
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Artifacts.Dtos
{
	[MessagePackObject]
	public class ActivateArtifactRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int HeroId;
		[Json]
		// [Key]
		public int ArtifactId;
	
		// Constructors
		public ActivateArtifactRequestDto() {}
	}
}
