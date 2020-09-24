
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Numerics;
using Plarium.Common.Serialization;
using SharedModel.Battle.Effects;
using SharedModel.Common.Hashing;
using SharedModel.Meta.Heroes;
using SharedModel.Meta.Stages;



namespace SharedModel.Meta.Skills
{
	[MessagePackObject]
	public class LeaderSkill : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public StatKindId StatKindId;
		[Json]
		// [Key]
		public bool IsAbsolute;
		[Json]
		// [Key]
		public Fixed Amount;
		[Json]
		// [Key]
		public AreaTypeId? Area;
		[Json]
		// [Key]
		public Element? Element;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public int GetAmount { get => default; }
	
		// Constructors
		public LeaderSkill() {}
	
		// Methods
		public override string ToString() => default;
		public override bool Equals(object obj) => default;
		protected bool Equals(LeaderSkill other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
	}
}
