
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Effects;



namespace SharedModel.Meta.Artifacts.Bonuses
{
	[MessagePackObject]
	public class ArtifactStatKey
	{
		// Fields
		[Json]
		// [Key]
		public StatKindId KindId;
		[Json]
		// [Key]
		public bool IsAbsolute;
	
		// Constructors
		public ArtifactStatKey() {}
		public ArtifactStatKey(StatKindId kindId, bool isAbsolute) {}
	
		// Methods
		protected bool Equals(ArtifactStatKey other) => default;
		public override bool Equals(object obj) => default;
		public override int GetHashCode() => default;
	}
}
