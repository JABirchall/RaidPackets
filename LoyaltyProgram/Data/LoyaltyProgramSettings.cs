
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.LoyaltyProgram.Data
{
	[MessagePackObject]
	public class LoyaltyProgramSettings
	{
		// Fields
		[Json]
		// [Key]
		public bool LoyaltyProgramEnabled;
		[Json]
		// [Key]
		public int RequiredLevel;
		[Json]
		// [Key]
		public int Daily90StartDayForOldUsers;
		[Json]
		// [Key]
		public List<LoyaltyProgramTypeId> ActiveLoyaltyPrograms;
		[Json]
		// [Key]
		public List<DailyRewardProgramSettings> EnabledDailyRewardPrograms;
	
		// Constructors
		public LoyaltyProgramSettings() {}
	
		// Methods
		public void OnInitialized() {}
	}
}
