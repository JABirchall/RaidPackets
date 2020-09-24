
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Configuration;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.AmazonIntegration
{
	[MessagePackObject]
	public class AmazonIntegrationSettings
	{
		// Fields
		[Json]
		// [Key]
		public bool Enabled;
		[Json]
		// [Key]
		public List<ConfigDateTime> PeriodStartDates;
		[Json]
		// [Key]
		public ConfigDateTime EndDate;
		[Json]
		// [Key]
		public string DefaultAboutAmazonPrimeUrl;
		[Json]
		// [Key]
		public List<UrlByRegion> AboutAmazonPrimeUrlByRegion;
		[Json]
		// [Key]
		public string DefaultAboutContentDropsUrl;
		[Json]
		// [Key]
		public List<UrlByRegion> AboutContentDropsUrlByRegion;
		[Json]
		// [Key]
		public string IntegrationServiceUrl;
		[Json]
		// [Key]
		public string AmazonNotificationServiceUrl;
		[Json]
		// [Key]
		public bool ExternalCallsEnabled;
		[Json]
		// [Key]
		public bool ExtendedLoggingEnabled;
	
		// Constructors
		public AmazonIntegrationSettings() {}
	}
}
