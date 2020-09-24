
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.FeatureStatuses;



namespace SharedModel.Meta.GlobalRatings
{
	[MessagePackObject]
	public class GlobalRatingSettings
	{
		// Fields
		[Json]
		// [Key]
		public FeatureStatus Status;
		[Json]
		// [Key]
		public int UpdateRatingTimeoutSeconds;
		[Json]
		// [Key]
		public int UpdatePlatinumCacheTimeoutSeconds;
		[Json]
		// [Key]
		public int GlobalRatingInfoSize;
		[Json]
		// [Key]
		public int PositionNotifyingIntervalSec;
		[Json]
		// [Key]
		public int RetrieveRatingUpdatesCount;
		[JsonSkip]
		// [Key]
		public int NoviceTournamentMaxUserLevel;
		[IgnoreMember]
		[Json]
		public int BEventGlobalRatingRequestStatusConcurrency;
		[IgnoreMember]
		[Json]
		public bool EnableBatchStatusesRequesting;
		[IgnoreMember]
		[Json]
		public int ProcessBatchTimeoutSeconds;
		[IgnoreMember]
		[Json]
		public int ProcessBatchRecordsCount;
		[IgnoreMember]
		[JsonSkip]
		public int NoviceTournamentStartAfterStageId;
		[IgnoreMember]
		[JsonSkip]
		public int CommonTournamentStartAfterStageId;
		[Json]
		// [Key]
		public double StoreClosedRatingsDays;
		[Json]
		// [Key]
		public double CloseRatingsSafetyMinutes;
		[Json]
		// [Key]
		public bool ShowSignInTournamentOverlays;
		[Json]
		// [Key]
		public string UrlFormat;
		[IgnoreMember]
		[JsonSkip]
		public bool Enabled;
	
		// Constructors
		public GlobalRatingSettings() {}
	}
}
