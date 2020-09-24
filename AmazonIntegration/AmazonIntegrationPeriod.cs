
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.AmazonIntegration
{
	[MessagePackObject]
	public class AmazonIntegrationPeriod
	{
		// Fields
		[Json]
		// [Key]
		public AmazonIntegrationPeriodId PeriodId;
		[Json]
		// [Key]
		public UserPrize Prize;
		[Json]
		// [Key]
		public string OfferId;
	
		// Constructors
		public AmazonIntegrationPeriod() {}
	}
}
