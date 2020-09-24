
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.Stages
{
	[MessagePackObject]
	public class StageSettings
	{
		// Fields
		[Json]
		// [Key]
		public bool StarsRewardEnabled;
		[Json]
		// [Key]
		public bool InsaneDifficultyEnabled;
		[Json]
		// [Key]
		public bool OpenKeepsEnabled;
		[Json]
		// [Key]
		public bool SpiderEnabled;
		[Json]
		// [Key]
		public bool CheckAreaCondition;
		[Json]
		// [Key]
		public bool CheckRegionCondition;
		[Json]
		// [Key]
		public int SelectedFormationIndex;
		[Json]
		// [Key]
		public Dictionary<RegionTypeId, int> RegionRevealLevelByType;
		[Json]
		// [Key]
		public Dictionary<AreaTypeId, int> AreaRevealLevelByType;
		[Json]
		// [Key]
		public Dictionary<RegionTypeId, double> NewUserOpenHoursByRegion;
		[Json]
		// [Key]
		public FractionWarSettings FractionWarSettings;
	
		// Constructors
		public StageSettings() {}
	
		// Methods
		public bool FractionWarEnabled(UserAccount account = null) => default;
		public bool FractionWarUserLevelValidate(UserAccount account) => default;
		public static Action<StageSettings> OnInitialized(bool isDevServer) => default;
	}
}
