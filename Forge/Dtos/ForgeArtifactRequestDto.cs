
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.BlackMarket;



namespace SharedModel.Meta.Forge.Dtos
{
	[MessagePackObject]
	public class ForgeArtifactRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int RecipeId;
		[Json]
		// [Key]
		public BlackMarketItemId[] Charms;
	
		// Constructors
		public ForgeArtifactRequestDto() {}
	}
}
