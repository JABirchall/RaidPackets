
using System;
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
	public class AllianceBossRewardTakingData
	{
		// Fields
		[Json]
		// [Key]
		public long AllianceId;
		[Json]
		// [Key]
		public DateTime RewardPeriodDate;
		[Json]
		// [Key]
		public AllianceBossDamageDealtRange DamageRange;
		[Json]
		// [Key]
		public int Damage;
	
		// Constructors
		public AllianceBossRewardTakingData() {}
	}
}
