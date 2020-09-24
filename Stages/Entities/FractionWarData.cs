
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.Stages;



namespace SharedModel.Meta.Stages.Entities
{
	[MessagePackObject]
	public class FractionWarData
	{
		// Fields
		[Json]
		// [Key]
		public DateTime GeneratedTime;
		[Json]
		// [Key]
		public Dictionary<HeroFraction, List<DateTime>> OpenDaysByFraction;
		[IgnoreMember]
		[JsonSkip]
		private DateTime _activeDataUpdateTime;
		[IgnoreMember]
		[JsonSkip]
		private HashSet<RegionTypeId> _activeRegionIds;
		[IgnoreMember]
		[JsonSkip]
		private HashSet<HeroFraction> _activeFractions;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public DateTime MaxOpenDate { get => default; }
	
		// Constructors
		public FractionWarData() {}
	
		// Methods
		public HashSet<RegionTypeId> ActiveRegionIds(DateTime now) => default;
		public HashSet<HeroFraction> ActiveFractions(DateTime now) => default;
		private void InitActiveDataIfNeeded(DateTime nowDate) {}
		public FractionWarData Clone() => default;
	}
}
