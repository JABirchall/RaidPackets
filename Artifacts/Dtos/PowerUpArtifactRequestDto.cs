
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.BlackMarket;



namespace SharedModel.Meta.Artifacts.Dtos
{
	[MessagePackObject]
	public class PowerUpArtifactRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int ArtifactId;
		[Json]
		// [Key]
		public BlackMarketItemId MaterialId;
	
		// Constructors
		public PowerUpArtifactRequestDto() {}
	}
}
