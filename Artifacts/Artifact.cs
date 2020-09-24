
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Artifacts.Bonuses;
using SharedModel.Meta.Artifacts.Sets;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Artifacts
{
	[MessagePackObject]
	public class Artifact
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public int SellPrice;
		[Json]
		// [Key]
		public int Price;
		[Json]
		// [Key]
		public int Level;
		[Json]
		// [Key]
		public bool IsActivated;
		[Json]
		// [Key]
		public ArtifactKindId KindId;
		[Json]
		// [Key]
		public ArtifactRankId RankId;
		[Json]
		// [Key]
		public ArtifactRarityId RarityId;
		[Json]
		// [Key]
		public ArtifactBonus PrimaryBonus;
		[Json]
		// [Key]
		public List<ArtifactBonus> SecondaryBonuses;
		[Json]
		// [Key]
		public ArtifactSetKindId SetKindId;
		[Json]
		// [Key]
		public HeroFraction RequiredFraction;
		[Json]
		// [Key]
		public bool IsSeen;
		[Json]
		// [Key]
		public int FailedUpgrades;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public ArtifactSetInfo SetInfo { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool IsArtifact { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool IsUnknownArtifact { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool IsAccessory { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool IsUnknownAccessory { get => default; }
	
		// Constructors
		public Artifact() {}
		public Artifact(ArtifactKindId kindId, ArtifactRankId rankId, ArtifactRarityId rarityId, ArtifactSetKindId setKindId, HeroFraction fraction = HeroFraction.Unknown) {}
		public Artifact(int sellPrice, int price, ArtifactKindId kindId, ArtifactRankId rankId, ArtifactRarityId rarityId, ArtifactSetKindId setKindId, HeroFraction fraction = HeroFraction.Unknown) {}
	
		// Methods
		public Artifact GetPrototype() => default;
		public Artifact Clone() => default;
		public override int GetHashCode() => default;
		public string ToStringShort() => default;
		public override bool Equals(object obj) => default;
		protected bool Equals(Artifact other) => default;
	}
}
