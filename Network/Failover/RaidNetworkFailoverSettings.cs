
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Network;



namespace SharedModel.Meta.Network.Failover
{
	[MessagePackObject]
	public class RaidNetworkFailoverSettings
	{
		// Fields
		[Json]
		// [Key]
		public int[] BundlesSendRequestIntervals;
		[Json]
		// [Key]
		public int[] BundlesTimeouts;
		[Json]
		// [Key]
		public BundlesRetryStrategy BundlesRetryStrategy;
		[Json]
		// [Key]
		public int MinStreamsForWifi;
		[Json]
		// [Key]
		public int MaxStreamsForWifi;
		[Json]
		// [Key]
		public int MinStreamsForMobileNetwork;
		[Json]
		// [Key]
		public int MaxStreamsForMobileNetwork;
		[Json]
		// [Key]
		public bool ServerLogsForBundleExceptionEnabled;
		[Json]
		// [Key]
		public ResourceErrorHandlingPolicies ResourceErrorHandlingPolicies;
	
		// Constructors
		public RaidNetworkFailoverSettings() {}
	}
}
