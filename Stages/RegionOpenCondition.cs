
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Enums;
using SharedModel.Common.Hashing;



namespace SharedModel.Meta.Stages
{
	[MessagePackObject]
	public class RegionOpenCondition : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public List<SharedModel.Common.Enums.DayOfWeek> OpenDays;
		[Json]
		// [Key]
		public int OpenHoursCount;
		[Json]
		// [Key]
		public int UserLevelRequired;
	
		// Constructors
		public RegionOpenCondition() {}
	
		// Methods
		public override bool Equals(object obj) => default;
		protected bool Equals(RegionOpenCondition other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
	}
}
