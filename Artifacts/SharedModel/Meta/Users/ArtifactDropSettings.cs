
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;
using SharedModel.Meta.Artifacts;
using SharedModel.Meta.Artifacts.Sets;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Artifacts.SharedModel.Meta.Users
{
	[MessagePackObject]
	public class ArtifactDropSettings : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public int Count;
		[Json]
		// [Key]
		public int Level;
		[Json]
		// [Key]
		public double Probability;
		[Json]
		// [Key]
		public Dictionary<ArtifactKindId, double> ProbsByKind;
		[Json]
		// [Key]
		public Dictionary<ArtifactRankId, double> ProbsByRank;
		[Json]
		// [Key]
		public Dictionary<ArtifactRarityId, double> ProbsByRarity;
		[Json]
		// [Key]
		public List<ArtifactSetKindId> Sets;
		[Json]
		// [Key]
		public List<HeroFraction> Fractions;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<ArtifactKindId, double> _kindProbs;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<ArtifactRankId, double> _rankProbs;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<ArtifactRarityId, double> _rarityProbs;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<ArtifactKindId, double> KindProbs { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<ArtifactRankId, double> RankProbs { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<ArtifactRarityId, double> RarityProbs { get => default; }
	
		// Constructors
		public ArtifactDropSettings() {}
	
		// Methods
		public ArtifactDropSettings Clone() => default;
		public bool InvalidData() => default;
		public override bool Equals(object obj) => default;
		protected bool Equals(ArtifactDropSettings other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
	}
}
