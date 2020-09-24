
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.DailyRewards.Data
{
	[MessagePackObject]
	public class UserDailyRewardData
	{
		// Fields
		[Json]
		// [Key]
		public DailyRewardProgramType CurrentProgramType;
		[Json]
		// [Key]
		public DateTime? CurrentProgramStartDate;
		[Json]
		// [Key]
		public List<DateTime> PrizeReceivedDates;
	
		// Constructors
		public UserDailyRewardData() {}
	}
}
