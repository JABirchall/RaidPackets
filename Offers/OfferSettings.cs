
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.AbTests;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Offers
{
	[MessagePackObject]
	public class OfferSettings
	{
		// Fields
		[Json]
		// [Key]
		public string OffersUrl;
		[Json]
		// [Key]
		public string ContentServiceUrl;
		[Json]
		// [Key]
		public bool GiveOffersEnabled;
		[Json]
		// [Key]
		public double AggressiveIconTimeSeconds;
		[Json]
		// [Key]
		public double ReleasePackLifeTimeSeconds;
		[Json]
		// [Key]
		public double StarterPackLifeTimeSeconds;
		[Json]
		// [Key]
		public double StarterPackLifeTimeSecondsGroupA;
		[Json]
		// [Key]
		public double StarterPackLifeTimeSecondsGroupB;
		[Json]
		// [Key]
		public double StarterPackShowDelaySeconds;
		[Json]
		// [Key]
		public double ReloadOffersTimeoutSeconds;
		[Json]
		// [Key]
		public int SkipOfferIdsMinUserId;
		[Json]
		// [Key]
		public List<int> SkipOfferIdsForNewUser;
		[Json]
		// [Key]
		public bool ExtendedLoggingEnabled;
		[Json]
		// [Key]
		public int MaxSimultaneousGiveOfferEvents;
		[Json]
		// [Key]
		public int MaxSimultaneousCloseOfferEvents;
		[Json]
		// [Key]
		public int DefaultRetentionOfferId;
		[Json]
		// [Key]
		public HeroRarity[] AvailableHeroRariry;
		[Json]
		// [Key]
		public int GiveOffersForSegmentBlockLimit;
		[Json]
		// [Key]
		public int GiveOffersForSegmentDelayMinutes;
		[Json]
		// [Key]
		public int AncientShard3PackId;
		[Json]
		// [Key]
		public int Silver500КPackId;
	
		// Constructors
		public OfferSettings() {}
	
		// Methods
		public double GetStarterPackLifeTimeSeconds(Dictionary<AbTestTypeId, AbTest> userTestsById, DateTime now) => default;
	}
}
