
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Core.Setup;
using SharedModel.Meta.Account;
using SharedModel.Meta.Alliances;
using SharedModel.Meta.Battle.Arena;
using SharedModel.Meta.Notifications.Enums;



namespace SharedModel.Meta.Notes
{
	[MessagePackObject]
	public class UserNote : INote
	{
		// Fields
		[Json]
		// [Key]
		public string SocialId;
		[Json]
		// [Key]
		public DateTime RegistrationTime;
		[Json]
		// [Key]
		public long Revision;
		[Json]
		// [Key]
		public string Name;
		[Json]
		// [Key]
		public int Level;
		[Json]
		// [Key]
		public UserAvatarId AvatarId;
		[Json]
		// [Key]
		public string LocaleName;
		[Json]
		// [Key]
		public string CustomAvatarUrl;
		[Json]
		// [Key]
		public TeamSetup ArenaDefense;
		[Json]
		// [Key]
		public double TotalPower;
		[Json]
		// [Key]
		public long? AllianceId;
		[Json]
		// [Key]
		public AllianceMemberRankId AllianceRankId;
		[Json]
		// [Key]
		public int? SubscriptionId;
		[Json]
		// [Key]
		public DateTime? LastActivityTime;
		[Json]
		// [Key]
		public Dictionary<NotificationSettingsGroup, NotificationState> NotificationSettings;
		[Json]
		// [Key]
		public int? FirstPlaceInPlatinumTimes;
		[Json]
		// [Key]
		public int? BattlePassLevel;
		[Json]
		// [Key]
		public int? BattlePassId;
		[Json]
		// [Key]
		public ModeratorRole? ModeratorRole;
	
		// Properties
		[Json]
		// [Key]
		public long Id { get; set; }
		[Json]
		// [Key]
		public int SegmentId { get; set; }
		[Json]
		// [Key]
		public ArenaLeagueId ArenaLeagueId { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool Outdated { get; set; }
		[IgnoreMember]
		[JsonSkip]
		public bool IsModerator { get => default; }
	
		// Constructors
		public UserNote() {}
		public UserNote(long id, string socialId, DateTime registrationTime, long revision, int level, string name, UserAvatarId avatar, TeamSetup setup, double totalPower, long? allianceId, AllianceMemberRankId allianceRankId, int? subscriptionId, DateTime lastActivityTime, string localeName, int? battlePassLevel, int? battlePassId, ModeratorRole? moderatorRole, string customAvatarUrl = null, int? firstPlaceInPlatinumTimes = default) {}
	}
}
