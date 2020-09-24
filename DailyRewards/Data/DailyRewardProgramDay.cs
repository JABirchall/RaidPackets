
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Attributes;
using SharedModel.Common.Localization;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.DailyRewards.Data
{
	[MessagePackObject]
	// [RemovedJson]
	public class DailyRewardProgramDay
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public int Day;
		[Json]
		// [Key]
		public UserPrize Prize;
		[Json]
		// [Key]
		// [SharedLocalization]
		public SharedLTextKey Text;
	
		// Constructors
		public DailyRewardProgramDay() {}
	}
}
