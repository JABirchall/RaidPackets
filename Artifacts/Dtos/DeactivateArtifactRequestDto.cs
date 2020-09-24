
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Artifacts.Dtos
{
	[MessagePackObject]
	public class DeactivateArtifactRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int HeroId;
		[Json]
		// [Key]
		public int? ArtifactId;
		[Json]
		// [Key]
		public List<int> ArtifactIds;
	
		// Constructors
		public DeactivateArtifactRequestDto() {}
	}
}
