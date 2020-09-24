
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Alliances;



namespace SharedModel.Meta.Alliances.Boss
{
	[MessagePackObject]
	public class AllianceBossData
	{
		// Fields
		[Json]
		// [Key]
		public DateTime StartTime;
		[Json]
		// [Key]
		public AllianceBossTypeId MaxUnlockedId;
		[Json]
		// [Key]
		public List<AllianceBoss> Bosses;
		[Json]
		// [Key]
		public Dictionary<long, UserAllianceBossRewardInfo> BossRewardInfoByUserId;
		[Json]
		// [Key]
		public Dictionary<long, List<AllianceBossTypeId>> ReceivedRewardsByUserId;
	
		// Constructors
		public AllianceBossData() {}
	
		// Methods
		public AllianceBoss GetBossById(AllianceBossTypeId id) => default;
	}
}
