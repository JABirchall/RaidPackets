
using System;
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
	public class GiveSetArtifactsDto
	{
		// Fields
		[Json]
		// [Key]
		public ArtifactSetKindId SetKindId;
		[Json]
		// [Key]
		public ArtifactKindId? KindId;
		[Json]
		// [Key]
		public HeroFraction? RequiredFraction;
		[Json]
		// [Key]
		public PrimaryBonusType PrimaryBonusType;
	
		// Constructors
		public GiveSetArtifactsDto() {}
		public GiveSetArtifactsDto(ArtifactSetKindId setKindId, ArtifactKindId? kindId, PrimaryBonusType primaryBonusType, HeroFraction? requiredFraction = default) {}
	}
}
