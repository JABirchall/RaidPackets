
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.AmazonIntegration
{
	[MessagePackObject]
	public class UserAmazonIntegrationData
	{
		// Fields
		[Json]
		// [Key]
		public bool Seen;
		[Json]
		// [Key]
		public bool SeenMarker;
		[Json]
		// [Key]
		public List<UserAmazonIntegrationClaimedReward> ClaimedPeriodRewards;
	
		// Constructors
		public UserAmazonIntegrationData() {}
	}
}
