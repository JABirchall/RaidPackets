
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Alliances.Boss;



namespace SharedModel.Meta.Alliances
{
	[MessagePackObject]
	public class UserAllianceBossRewardInfo
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<AllianceBossTypeId, List<AllianceBossReward>> RewardsByBossId;
		[Json]
		// [Key]
		public DateTime BossPeriodTime;
	
		// Constructors
		public UserAllianceBossRewardInfo() {}
	}
}
