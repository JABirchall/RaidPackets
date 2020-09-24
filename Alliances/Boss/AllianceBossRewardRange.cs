
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Alliances.Boss
{
	[MessagePackObject]
	public class AllianceBossRewardRange
	{
		// Fields
		[Json]
		// [Key]
		public AllianceBossDamageDealtRange RangeId;
		[Json]
		// [Key]
		public double LowPercent;
		[Json]
		// [Key]
		public double HighPercent;
	
		// Constructors
		public AllianceBossRewardRange() {}
	
		// Methods
		public bool IsInRange(double value) => default;
	}
}
