
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.FeatureStatuses;



namespace SharedModel.Meta.Stages
{
	[MessagePackObject]
	public class FractionWarSettings
	{
		// Fields
		[Json]
		// [Key]
		public FeatureStatus Status;
		[Json]
		// [Key]
		public int OpenedFractionsCountInOneDay;
		[Json]
		// [Key]
		public double UpdateFractionWarDataDelayMinutes;
		[Json]
		// [Key]
		public double NewUserFreeRegionDays;
		[Json]
		// [Key]
		public double KeysLimit;
		[Json]
		// [Key]
		public bool IsBetaStatus;
		[Json]
		// [Key]
		public bool MainRewardEnabled;
	
		// Constructors
		public FractionWarSettings() {}
	}
}
