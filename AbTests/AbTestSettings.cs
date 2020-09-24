
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.AbTests
{
	[MessagePackObject]
	public class AbTestSettings
	{
		// Fields
		[Json]
		// [Key]
		public int StoryDifficultyFormationIndexForB;
		[Json]
		// [Key]
		public List<AbTestTypeId> ActiveTests;
		[Json]
		// [Key]
		public Dictionary<AbTestTypeId, Dictionary<AbTestGroupId, double>> ProbabilitiesForAbTest;
	
		// Constructors
		public AbTestSettings() {}
	
		// Methods
		public void OnInitialized() {}
	}
}
