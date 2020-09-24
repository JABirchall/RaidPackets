
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Artifacts.Sets;



namespace SharedModel.Meta.Forge.Static
{
	[MessagePackObject]
	public class ForgeArtifactRecipe
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public ArtifactSetKindId ArtifactSetKindId;
		[Json]
		// [Key]
		public OutputRankVariationId OutputRankVariationId;
		[Json]
		// [Key]
		public Account.Resources Price;
	
		// Constructors
		public ForgeArtifactRecipe() {}
	}
}
