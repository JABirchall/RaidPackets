
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Stages;



namespace SharedModel.Meta.Alliances.Activity
{
	[MessagePackObject]
	public class AllianceActivityData
	{
		// Fields
		[Json]
		// [Key]
		public int Stars;
		[Json]
		// [Key]
		public DateTime LastRefreshTime;
		[Json]
		// [Key]
		public DateTime LastRewardTime;
		[Json]
		// [Key]
		public DateTime? LastRecalcTime;
		[Json]
		// [Key]
		public FlexibleReward FlexibleReward;
	
		// Constructors
		public AllianceActivityData() {}
	}
}
