
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Alliances
{
	[MessagePackObject]
	public class DailyActivityInfoSettings
	{
		// Fields
		[Json]
		// [Key]
		public double TwoStarsOnlineTimeMs;
		[Json]
		// [Key]
		public double TwoStarsClanDungeonBossCount;
		[Json]
		// [Key]
		public double TwoStarsStoryAndDungeonBattlesCount;
		[Json]
		// [Key]
		public double TwoStarsArenaBattlesCount;
		[Json]
		// [Key]
		public double ThreeStarsOnlineTimeMs;
		[Json]
		// [Key]
		public double ThreeStarsClanDungeonBossCount;
		[Json]
		// [Key]
		public double ThreeStarsStoryAndDungeonBattlesCount;
		[Json]
		// [Key]
		public double ThreeStarsArenaBattlesCount;
	
		// Constructors
		public DailyActivityInfoSettings() {}
	}
}
