
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Alliances
{
	[MessagePackObject]
	public class AllianceMember
	{
		// Fields
		[Json]
		// [Key]
		public long UserId;
		[Json]
		// [Key]
		public AllianceMemberRankId RankId;
		[Json]
		// [Key]
		public DateTime JoinDate;
		[Json]
		// [Key]
		public DateTime LastVisitDate;
		[Json]
		// [Key]
		public int Power;
		[Json]
		// [Key]
		public int Level;
		[Json]
		// [Key]
		public Dictionary<DateTime, int> ActivityStarsByDate;
		[Json]
		// [Key]
		public DateTime LastRewardReceiveTime;
	
		// Constructors
		public AllianceMember() {}
		public AllianceMember(long userId, AllianceMemberRankId rankId, DateTime visitDate, DateTime joinDate) {}
	
		// Methods
		public bool IsActiveUser(DateTime currentData) => default;
		public bool IsOnline(DateTime currentTime) => default;
	}
}
