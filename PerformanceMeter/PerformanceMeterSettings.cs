
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.PerformanceMeter
{
	[MessagePackObject]
	public class PerformanceMeterSettings
	{
		// Fields
		[Json]
		// [Key]
		public bool Enabled;
		[Json]
		// [Key]
		public double FpsCollectingIntervalMs;
		[Json]
		// [Key]
		public double PercentilePercent;
		[Json]
		// [Key]
		public double MinViewOpenedTimeMs;
		[Json]
		// [Key]
		public int MinRefreshTimeMs;
		[Json]
		// [Key]
		public int[] IgnoreTrackingForViewKeys;
		[Json]
		// [Key]
		public Dictionary<int, int[]> IgnoreOverlaysForViewKeys;
		[Json]
		// [Key]
		public double[] ProvidingPercentiles;
		[Json]
		// [Key]
		public StatisticsType[] EnabledStatisticsTypes;
	
		// Constructors
		public PerformanceMeterSettings() {}
	}
}
