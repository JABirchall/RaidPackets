
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Alliances;
using SharedModel.Meta.Stages;



namespace SharedModel.Meta.Alliances.Boss
{
	[MessagePackObject]
	public class AllianceBossReward
	{
		// Fields
		[Json]
		// [Key]
		public AllianceRewardTypeId TypeId;
		[Json]
		// [Key]
		public AllianceBossDamageDealtRange Range;
		[Json]
		// [Key]
		public int? Damage;
		[Json]
		// [Key]
		public FlexibleReward FlexibleReward;
	
		// Constructors
		public AllianceBossReward() {}
	
		// Methods
		public AllianceBossReward Clone() => default;
	}
}
