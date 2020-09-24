
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
	public class SwapArtifactRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int HeroId;
		[Json]
		// [Key]
		public int ArtifactFromId;
		[Json]
		// [Key]
		public int ArtifactToId;
		[Json]
		// [Key]
		public int ArtifactOwnerHeroId;
	
		// Constructors
		public SwapArtifactRequestDto() {}
	}
}
