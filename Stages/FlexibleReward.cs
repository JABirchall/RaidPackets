
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;



namespace SharedModel.Meta.Stages
{
	[MessagePackObject]
	public class FlexibleReward : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public List<FlexibleRewardInfo> Rewards;
		[Json]
		// [Key]
		public bool CompareArtifactsByItsProperties;
		[Json]
		// [Key]
		public int Count;
		[Json]
		// [Key]
		public Dictionary<int, double> ArtifactProbsByKindId;
		[Json]
		// [Key]
		public Dictionary<int, double> ArtifactProbsByRankId;
		[Json]
		// [Key]
		public Dictionary<int, double> ArtifactProbsByRarityId;
		[Json]
		// [Key]
		public Dictionary<int, double> ArtifactProbsBySetKindId;
		[Json]
		// [Key]
		public Dictionary<int, double> AccessoryProbsByKindId;
		[Json]
		// [Key]
		public Dictionary<int, double> AccessoryProbsByRankId;
		[Json]
		// [Key]
		public Dictionary<int, double> AccessoryProbsByRarityId;
		[Json]
		// [Key]
		public Dictionary<int, double> AccessoryProbsByHeroFraction;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<int, double> _rewardProbsByIndex;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<int, double> _artifactKindIdProbs;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<int, double> _artifactRankIdProbs;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<int, double> _artifactRarityIdProbs;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<int, double> _artifactSetKindIdProbs;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<int, double> _accessoryKindIdProbs;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<int, double> _accessoryRankIdProbs;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<int, double> _accessoryRarityIdProbs;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<int, double> _accessoryHeroFractionProbs;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<int, double> RewardProbsByIndex { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<int, double> ArtifactKindIdProbs { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<int, double> ArtifactRankIdProbs { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<int, double> ArtifactRarityIdProbs { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<int, double> ArtifactSetKindIdProbs { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<int, double> AccessoryKindIdProbs { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<int, double> AccessoryRankIdProbs { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<int, double> AccessoryRarityIdProbs { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<int, double> AccessoryHeroFractionProbs { get => default; }
	
		// Constructors
		public FlexibleReward() {}
	
		// Methods
		private Dictionary<int, double> InitializeProps() => default;
		private double GenerateProbability(double sumProb, double probability) => default;
		public override bool Equals(object obj) => default;
		protected bool Equals(FlexibleReward other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
		public FlexibleReward Clone() => default;
	}
}
