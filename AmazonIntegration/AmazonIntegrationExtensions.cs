
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.AmazonIntegration
{
	public static class AmazonIntegrationExtensions
	{
		// Extension methods
		public static AmazonIntegrationPeriod FindCurrentPeriod(this StaticAmazonIntegrationData data, DateTime now) => default;
		public static bool HasUserClaimedRewardFor(this UserAmazonIntegrationData data, AmazonIntegrationPeriod period) => default;
	}
}
