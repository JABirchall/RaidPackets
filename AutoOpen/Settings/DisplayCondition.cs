
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Offers.Enums;



namespace SharedModel.Meta.AutoOpen.Settings
{
	[MessagePackObject]
	public class DisplayCondition
	{
		// Fields
		[Json]
		// [Key]
		public bool? AlwaysDisplay;
		[Json]
		// [Key]
		public bool? IsNew;
		[Json]
		// [Key]
		public OfferTypeId? HasOfferTypeId;
		[Json]
		// [Key]
		public int? HasOfferPromoId;
		[Json]
		// [Key]
		public bool? UseOffersLimit;
		[Json]
		// [Key]
		public int? HasTriggerKindId;
		[Json]
		// [Key]
		public int? SessionLimit;
		[Json]
		// [Key]
		public HourlyDisplayLimit HourlyLimit;
		[Json]
		// [Key]
		public int? DailyTotalDisplayLimit;
		[Json]
		// [Key]
		public int? DisplayDelayDays;
		[Json]
		// [Key]
		public int? DisplayDelayMinutes;
		[Json]
		// [Key]
		public int? DisplayGlobalDelayMinutes;
		[Json]
		// [Key]
		public RequiredResources RequiredResources;
		[Json]
		// [Key]
		public int? SessionBattlesCount;
		[Json]
		// [Key]
		public int? UserLevelBecome;
		[Json]
		// [Key]
		public int? CustomViewKey;
		[Json]
		// [Key]
		public bool? AffectOffersLimit;
	
		// Constructors
		public DisplayCondition() {}
	}
}
