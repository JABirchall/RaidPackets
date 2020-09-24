
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
	public class StaticAmazonIntegrationData
	{
		// Fields
		[Json]
		// [Key]
		public AmazonIntegrationSettings Settings;
		[Json]
		// [Key]
		public List<AmazonIntegrationPeriod> Periods;
	
		// Constructors
		public StaticAmazonIntegrationData() {}
	}
}
