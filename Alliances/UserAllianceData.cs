
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
using SharedModel.Meta.Chat;



namespace SharedModel.Meta.Alliances
{
	[MessagePackObject]
	public class UserAllianceData
	{
		// Fields
		[Json]
		// [Key]
		public long? AllianceId;
		[Json]
		// [Key]
		public AllianceMemberRankId? RankId;
		[Json]
		// [Key]
		public DateTime? JoinDate;
		[Json]
		// [Key]
		public List<UserAllianceRequest> Requests;
		[Json]
		// [Key]
		public List<UserAllianceInvitation> Invitations;
		[Json]
		// [Key]
		public Dictionary<ChatRoomName, AllianceChatRoomData> AllianceChatRooms;
		[Json]
		// [Key]
		public DateTime? LeavingDate;
		[Json]
		// [Key]
		public UserBossAttackInfo CurrentBossAttack;
		[Json]
		// [Key]
		public UserAllianceActivityData AllianceActivityData;
		[Json]
		// [Key]
		public Dictionary<AllianceBossTypeId, AllianceBossRewardTakingData> ReceivedRewards;
	
		// Constructors
		public UserAllianceData() {}
	}
}
