
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.Alliances
{
	[MessagePackObject]
	public class AllianceSettings
	{
		// Fields
		[Json]
		// [Key]
		public bool Enabled;
		[Json]
		// [Key]
		public double AchievementStorageSyncCooldownSeconds;
		[Json]
		// [Key]
		public int RevealUserLevel;
		[Json]
		// [Key]
		public int CreationPriceGems;
		[Json]
		// [Key]
		public int CreationRequiredUserLevel;
		[Json]
		// [Key]
		public int MaximumInvitationCount;
		[Json]
		// [Key]
		public int MaximumRequestsCount;
		[Json]
		// [Key]
		public int MaximumUserPendingRequestsNumber;
		[Json]
		// [Key]
		public double DeletionPeriodHours;
		[Json]
		// [Key]
		public int AllianceSize;
		[Json]
		// [Key]
		public int MaxDeputyCount;
		[Json]
		// [Key]
		public int NameCharactersLimit;
		[Json]
		// [Key]
		public int NameCharactersMin;
		[Json]
		// [Key]
		public int AbbreviationCharactersLimit;
		[Json]
		// [Key]
		public int AbbreviationCharactersMin;
		[Json]
		// [Key]
		public int DescriptionCharactersLimit;
		[Json]
		// [Key]
		public int MessageCharactersLimit;
		[Json]
		// [Key]
		public int MaxBossKeys;
		[Json]
		// [Key]
		public double FreeBossKeyHours;
		[Json]
		// [Key]
		public int StartPriceKeys;
		[Json]
		// [Key]
		public double BossLifetimeDays;
		[Json]
		// [Key]
		public double RefreshTimeHoursUtc;
		[IgnoreMember]
		[Json]
		public int BEventNormalizeAllianceSpreadingSeconds;
		[IgnoreMember]
		[Json]
		public int BEventNormalizeAllianceConcurrencyLevel;
		[Json]
		// [Key]
		public int RequiredActivityStars;
		[Json]
		// [Key]
		public double ActivityRecalcDelayMinutes;
		[Json]
		// [Key]
		public double ActivityRefreshDays;
		[Json]
		// [Key]
		public double StoreActivityInfoDays;
		[Json]
		// [Key]
		public int MaxAllianceActivityStars;
		[Json]
		// [Key]
		public double StoreRequestsDays;
		[Json]
		// [Key]
		public double RenamePriceInGems;
		[Json]
		// [Key]
		public double ChangeAbbreviationPriceInGems;
		[Json]
		// [Key]
		public double RenameDelayHours;
		[Json]
		// [Key]
		public double ChangeAbbreviationDelayHours;
		[Json]
		// [Key]
		public int MaxSearchAllianceCount;
		[Json]
		// [Key]
		public int SearchAllianceCount;
		[Json]
		// [Key]
		public bool AllianceChatEnabled;
		[Json]
		// [Key]
		public bool LogOnSearch;
		[Json]
		// [Key]
		public Dictionary<ResourceTypeId, Dictionary<ResourceTypeId, int>> RatioByMedalTypes;
		[Json]
		// [Key]
		public DailyActivityInfoSettings DailyActivityInfoSettings;
		[Json]
		// [Key]
		public double InactiveUserStatusDelayDays;
		[Json]
		// [Key]
		public double DemotionInactiveLeaderDelayDays;
		[IgnoreMember]
		[JsonSkip]
		private Account.Resources _renamePrice;
		[IgnoreMember]
		[JsonSkip]
		private Account.Resources _changeAbbreviationPrice;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public Account.Resources RenamePrice { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public Account.Resources ChangeAbbreviationPrice { get => default; }
	
		// Constructors
		public AllianceSettings() {}
	}
}
