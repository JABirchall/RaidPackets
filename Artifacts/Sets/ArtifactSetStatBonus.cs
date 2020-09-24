
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



namespace SharedModel.Meta.Artifacts.Sets
{
	[MessagePackObject]
	public class ArtifactSetStatBonus : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public StatKindId StatKindId;
		[Json]
		// [Key]
		public Fixed Value;
		[Json]
		// [Key]
		public bool IsAbsolute;
	
		// Constructors
		public ArtifactSetStatBonus() {}
		public ArtifactSetStatBonus(StatKindId statKindId, Fixed value, bool isAbsolute) {}
	
		// Methods
		public ArtifactSetStatBonus Clone() => default;
		public override string ToString() => default;
		public override bool Equals(object obj) => default;
		protected bool Equals(ArtifactSetStatBonus other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
	}
}
