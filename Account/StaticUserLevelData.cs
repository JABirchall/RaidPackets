
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Account
{
	[MessagePackObject]
	public class StaticUserLevelData
	{
		// Fields
		[Json]
		// [Key]
		public int MaxLevel;
		[Json]
		// [Key]
		public double EnergyPerHour;
		[Json]
		// [Key]
		public List<int> ExperienceForLevel;
		[Json]
		// [Key]
		public List<int> EnergyLimitForLevel;
		[Json]
		// [Key]
		public Dictionary<int, UserPrize> PrizesByLevel;
		[Json]
		// [Key]
		public UserPrize PrizeForNewLevel;
		[Json]
		// [Key]
		public Dictionary<int, UserPrize> MilestonePrizesForLevel;
	
		// Constructors
		public StaticUserLevelData() {}
	}
}
