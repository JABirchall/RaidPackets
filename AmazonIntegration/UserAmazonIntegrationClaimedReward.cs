
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.AmazonIntegration
{
	[MessagePackObject]
	public class UserAmazonIntegrationClaimedReward
	{
		// Fields
		[Json]
		// [Key]
		public AmazonIntegrationPeriodId PeriodId;
		[Json]
		// [Key]
		public DateTime ClaimTime;
	
		// Constructors
		public UserAmazonIntegrationClaimedReward() {}
		public UserAmazonIntegrationClaimedReward(AmazonIntegrationPeriodId periodId, DateTime claimTime) {}
	}
}
