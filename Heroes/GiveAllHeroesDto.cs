
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Heroes
{
	[MessagePackObject]
	public class GiveAllHeroesDto
	{
		// Fields
		[Json]
		// [Key]
		public bool MaxLevel;
		[Json]
		// [Key]
		public bool MaxAwakeLevel;
		[Json]
		// [Key]
		public bool AllowDuplicates;
		[Json]
		// [Key]
		public bool MaxMasteryPoints;
	
		// Constructors
		public GiveAllHeroesDto() {}
		public GiveAllHeroesDto(bool maxLevel, bool maxAwakeLevel, bool maxMasteryPoints, bool allowDuplicates) {}
	}
}
