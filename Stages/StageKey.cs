
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



namespace SharedModel.Meta.Stages
{
	public struct StageKey : IEquatable<SharedModel.Meta.Stages.StageKey>
	{
		// Fields
		public readonly AreaTypeId AreaTypeId;
		public readonly RegionTypeId? RegionTypeId;
		public readonly DifficultyId? DifficultyId;
	
		// Constructors
		public StageKey(AreaTypeId areaTypeId, RegionTypeId? regionTypeId, DifficultyId? difficultyId) {
			AreaTypeId = default;
			RegionTypeId = default;
			DifficultyId = default;
		}
	
		// Methods
		public bool Equals(StageKey other) => default;
		public override bool Equals(object obj) => default;
		public override int GetHashCode() => default;
	}
}
