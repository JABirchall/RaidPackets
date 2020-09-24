
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Meta.DailyRewards.Data;



namespace SharedModel.Meta.DailyRewards
{
	public static class DailyRewardExtensions
	{
		// Extension methods
		public static DailyRewardProgramDay GetCurrentProgramDay(this UserDailyRewardData data) => default;
		public static DailyRewardProgramType GetNextProgram(this DailyRewardProgramType type) => default;
		public static bool CanStartNextProgram(this UserDailyRewardData data, DailyRewardProgramType nextProgram, DateTime now) => default;
		public static void StartProgram(this UserDailyRewardData data, DailyRewardProgramType programType, DateTime now) {}
	}
}
