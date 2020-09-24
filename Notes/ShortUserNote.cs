
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Alliances;
using SharedModel.Meta.Battle.Arena;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.Notifications.Enums;



namespace SharedModel.Meta.Notes
{
	[MessagePackObject]
	public class ShortUserNote
	{
		// Fields
		[Json]
		// [Key]
		public long Id;
		[Json]
		// [Key]
		public int SegmentId;
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
		public List<ShortHeroInfo> ArenaDefenseHeroes;
		[Json]
		// [Key]
		public int ArenaDefensePower;
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
		public ArenaLeagueId ArenaLeagueId;
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
	
		// Constructors
		public ShortUserNote() {}
		public ShortUserNote(UserNote note) {}
	}
}
