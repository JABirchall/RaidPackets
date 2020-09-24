
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
	public class Region : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public RegionTypeId Id;
		[Json]
		// [Key]
		// [SharedLocalization]
		public SharedLTextKey Name;
		[Json]
		// [Key]
		public RegionOpenCondition Condition;
		[Json]
		// [Key]
		public Dictionary<DifficultyId, List<int>> StageIdsByDifficulty;
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<DifficultyId, List<Stage>> StagesByDifficulty;
	
		// Constructors
		public Region() {}
	
		// Methods
		public override bool Equals(object obj) => default;
		protected bool Equals(Region other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
	}
}
