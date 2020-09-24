
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Attributes;
using SharedModel.Common.Device;
using SharedModel.Meta.LoyaltyProgram.Data;
using SharedModel.Meta.Sessions;



namespace SharedModel.Meta.CommonData
{
	[MessagePackObject]
	// [RemovedJson]
	public class UserCommonData
	{
		// Fields
		[Json]
		// [Key]
		public DateTime RegistrationTime;
		[Json]
		// [Key]
		public DateTime LastActivityTime;
		[Json]
		// [Key]
		public DateTime LastSignInTime;
		[Json]
		// [Key]
		public DateTime? LastSignInTimePrev;
		[Json]
		// [Key]
		public int SessionsCount;
		[Json]
		// [Key]
		public long TotalInGameTimeMs;
		[Json]
		// [Key]
		public long InGameTimeMs;
		[Json]
		// [Key]
		public List<UserSessionInfo> LastUserSessions;
		[Json]
		// [Key]
		public List<DateTime> SignInDates;
		[Json]
		// [Key]
		public long? ActiveSessionId;
		[Json]
		// [Key]
		public long? LastSessionId;
		[Json]
		// [Key]
		public DateTime LastSessionOpenedTime;
		[Json]
		// [Key]
		public DateTime? LastSessionClosedTime;
		[Json]
		// [Key]
		public DateTime? LastSessionUpdatedTime;
		[Json]
		// [Key]
		public DateTime? LastLevelUpTime;
		[Json]
		// [Key]
		public string RegistrationIp;
		[Json]
		// [Key]
		public string LastSignInIp;
		[Json]
		// [Key]
		public ClientInfo ClientInfo;
		[Json]
		// [Key]
		public bool UserSkippedWizard;
		[Json]
		// [Key]
		public bool UserSkippedStoryline;
		[Json]
		// [Key]
		public DateTime? ForcedWizardCompletedTime;
		[Json]
		// [Key]
		public double TimeZone;
		[Json]
		// [Key]
		public int DayInARow;
		[Json]
		// [Key]
		public DateTime? RatedDateTime;
		[Json]
		// [Key]
		public int RateShownCount;
		[Json]
		// [Key]
		public int RatedValue;
		[Json]
		// [Key]
		public string LastRewardedClientVersion;
		[Json]
		// [Key]
		public Dictionary<LoyaltyProgramTypeId, int> LoyaltyProgramDayByTypeId;
		[Json]
		// [Key]
		public Dictionary<string, string> FacebookBusinessIds;
		[Json]
		// [Key]
		public bool AccountIsDeleting;
		[Json]
		// [Key]
		public int TodayLoginsCount;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public TimeSpan TimeSinceRegistration { get => default; }
	
		// Constructors
		public UserCommonData() {}
	}
}
