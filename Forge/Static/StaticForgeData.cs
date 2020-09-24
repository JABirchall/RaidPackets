
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Forge;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Forge.Static
{
	[MessagePackObject]
	public class StaticForgeData
	{
		// Fields
		[Json]
		// [Key]
		public ForgeCharmProbabilities Probabilities;
		[Json]
		// [Key]
		public UserPrize FirstTimeReward;
		[Json]
		// [Key]
		public List<ForgeArtifactRecipe> ForgeArtifactRecipes;
		[Json]
		// [Key]
		public ForgeSettings Settings;
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<int, ForgeArtifactRecipe> RecipesById;
	
		// Constructors
		public StaticForgeData() {}
	
		// Methods
		public void Cache() {}
	}
}
