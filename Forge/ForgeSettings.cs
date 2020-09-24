
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Forge.Static;



namespace SharedModel.Meta.Forge
{
	[MessagePackObject]
	public class ForgeSettings
	{
		// Fields
		[Json]
		// [Key]
		public bool Enabled;
		[Json]
		// [Key]
		public List<int> ActiveRecipes;
		[Json]
		// [Key]
		public ForgeRewards FirstTimeReward;
		[Json]
		// [Key]
		public Dictionary<ForgeCharmProbabilitiesTypeId, List<double>> Probabilities;
	
		// Constructors
		public ForgeSettings() {}
	}
}
