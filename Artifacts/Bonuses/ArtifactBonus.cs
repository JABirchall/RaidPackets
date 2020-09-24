
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Numerics;
using Plarium.Common.Serialization;
using SharedModel.Battle.Effects;
using SharedModel.Meta.Artifacts;



namespace SharedModel.Meta.Artifacts.Bonuses
{
	[MessagePackObject]
	public class ArtifactBonus
	{
		// Fields
		[Json]
		// [Key]
		public StatKindId KindId;
		[Json]
		// [Key]
		public BonusValue Value;
		[Json]
		// [Key]
		public Fixed PowerUpValue;
		[Json]
		// [Key]
		public int Level;
	
		// Constructors
		public ArtifactBonus() {}
		public ArtifactBonus(StatKindId kindId, BonusValue value) {}
	
		// Methods
		public ArtifactBonus Clone() => default;
		public override int GetHashCode() => default;
		public override bool Equals(object obj) => default;
		protected bool Equals(ArtifactBonus other) => default;
		public ArtifactStatKey ToStatKey() => default;
	}
}
