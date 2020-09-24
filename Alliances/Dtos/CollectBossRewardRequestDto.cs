
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Alliances.Boss;



namespace SharedModel.Meta.Alliances.Dtos
{
	[MessagePackObject]
	public class CollectBossRewardRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public long AllianceId;
		[Json]
		// [Key]
		public AllianceBossTypeId BossId;
	
		// Constructors
		public CollectBossRewardRequestDto() {}
	}
}
