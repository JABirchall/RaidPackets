
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;
using SharedModel.Meta.Artifacts.Bonuses;
using SharedModel.Meta.Artifacts.Sets;



namespace SharedModel.Meta.Artifacts
{
	[MessagePackObject]
	public class ArtifactSuggestion : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public ArtifactKindId KindId;
		[Json]
		// [Key]
		public ArtifactSetKindId SetKindId;
		[Json]
		// [Key]
		public List<ArtifactStatKey> PrimaryBonuses;
	
		// Constructors
		public ArtifactSuggestion() {}
	
		// Methods
		public override bool Equals(object obj) => default;
		protected bool Equals(ArtifactSuggestion other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
	}
}
