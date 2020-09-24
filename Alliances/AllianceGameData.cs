
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Alliances.Activity;
using SharedModel.Meta.Alliances.Boss;



namespace SharedModel.Meta.Alliances
{
	[MessagePackObject]
	public class AllianceGameData
	{
		// Fields
		[Json]
		// [Key]
		public long Revision;
		[Json]
		// [Key]
		public bool DeletionInProgress;
		[Json]
		// [Key]
		public DateTime CreationTime;
		[Json]
		// [Key]
		public DateTime? DeletionTime;
		[Json]
		// [Key]
		public long CreatorUserId;
		[Json]
		// [Key]
		public AllianceAppearanceData AppearanceData;
		[Json]
		// [Key]
		public AllianceMembershipData MembershipData;
		[Json]
		// [Key]
		public AllianceChatData ChatData;
		[Json]
		// [Key]
		public AllianceBossData BossData;
		[Json]
		// [Key]
		public AllianceActivityData ActivityData;
		[Json]
		// [Key]
		public DateTime? LastTimeRenamed;
		[Json]
		// [Key]
		public DateTime? LastTimeAbbreviationChanged;
		[Json]
		// [Key]
		public AllianceAchievementData AchievementData;
		[Json]
		// [Key]
		public DateTime NormalizationTime;
	
		// Constructors
		public AllianceGameData() {}
	
		// Methods
		public void ChangeRevision() {}
		public List<long> GetKnownUserIds() => default;
	}
}
