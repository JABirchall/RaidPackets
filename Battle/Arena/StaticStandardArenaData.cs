
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Battle.Arena
{
	[MessagePackObject]
	public class StaticStandardArenaData : StaticArenaData
	{
		// Fields
		[Json]
		// [Key]
		public int DowngradeToZeroLeagueDays;
		[Json]
		// [Key]
		public UserPrize[] SuperLeagueWeeklyPrizes;
		[Json]
		// [Key]
		public int WeeklyRewardsUtcHour;
		[Json]
		// [Key]
		public bool NewPlatinumWeeklyRewardsEnabled;
	
		// Constructors
		public StaticStandardArenaData() {}
	}
}
