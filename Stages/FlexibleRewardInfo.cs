
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;
using SharedModel.Meta.Account;
using SharedModel.Meta.Artifacts;
using SharedModel.Meta.Artifacts.Sets;
using SharedModel.Meta.BlackMarket;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Stages
{
	[MessagePackObject]
	public class FlexibleRewardInfo : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public FlexibleRewardType Type;
		[Json]
		// [Key]
		public double Probability;
		[Json]
		// [Key]
		public int MinCount;
		[Json]
		// [Key]
		public int MaxCount;
		[Json]
		// [Key]
		public DateTime? From;
		[Json]
		// [Key]
		public DateTime? To;
		[Json]
		// [Key]
		public int? HeroId;
		[Json]
		// [Key]
		public HeroGrade? HeroGrade;
		[Json]
		// [Key]
		public ArtifactKindId? KindId;
		[Json]
		// [Key]
		public ArtifactRankId? RankId;
		[Json]
		// [Key]
		public ArtifactRarityId? RarityId;
		[Json]
		// [Key]
		public ArtifactSetKindId? SetKindId;
		[Json]
		// [Key]
		public HeroFraction? HeroFraction;
		[Json]
		// [Key]
		public BlackMarketItemId? BlackMarketItemId;
		[Json]
		// [Key]
		public ResourceTypeId? ResourceTypeId;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public bool IsTemporary { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool IsAvailable { get => default; }
	
		// Constructors
		public FlexibleRewardInfo() {}
	
		// Methods
		public override bool Equals(object obj) => default;
		protected bool Equals(FlexibleRewardInfo other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
		public FlexibleRewardInfo Clone() => default;
		private bool EqualsNullableDateTime(DateTime? first, DateTime? second) => default;
	}
}
