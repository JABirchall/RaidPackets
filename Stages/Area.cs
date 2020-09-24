
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;
using SharedModel.Common.Localization;



namespace SharedModel.Meta.Stages
{
	[MessagePackObject]
	public class Area : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public AreaTypeId Id;
		[Json]
		// [Key]
		// [SharedLocalization]
		public SharedLTextKey Name;
		[Json]
		// [Key]
		public AreaOpenCondition Condition;
		[Json]
		// [Key]
		public List<Region> Regions;
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<RegionTypeId, Region> RegionsById;
	
		// Constructors
		public Area() {}
	
		// Methods
		public override bool Equals(object obj) => default;
		protected bool Equals(Area other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
	}
}
