
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Effects;
using SharedModel.Common.Hashing;
using SharedModel.Common.Localization;



namespace SharedModel.Meta.Skills
{
	[MessagePackObject]
	public class SkillType : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public int Revision;
		[Json]
		// [Key]
		// [SharedLocalization]
		public SharedLTextKey Name;
		[Json]
		// [Key]
		// [SharedLocalization]
		public SharedLTextKey Description;
		[Json]
		// [Key]
		public SkillGroup Group;
		[Json]
		// [Key]
		public SkillTargets? Targets;
		[Json]
		// [Key]
		public int Cooldown;
		[Json]
		// [Key]
		public bool ReduceCooldownProhibited;
		[Json]
		// [Key]
		public bool IsHidden;
		[Json]
		// [Key]
		public bool ShowDamageScale;
		[Json]
		// [Key]
		public bool? IsHiddenOnHudOld;
		[Json]
		// [Key]
		public Visibility Visibility;
		[Json]
		// [Key]
		public HeroesSetInfo HeroesSetInfo;
		[Json]
		// [Key]
		public List<SkillBonus> LevelBonuses;
		[Json]
		// [Key]
		public List<EffectType> Effects;
		[Json]
		// [Key]
		public bool? EnableVisualizationForPassiveSkill;
		[Json]
		// [Key]
		public bool? IsCheatSkill;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public bool? IsHiddenOnHud { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool IsDefault { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public int MaxLevel { get => default; }
	
		// Constructors
		public SkillType() {}
	
		// Methods
		public void Validate() {}
		public override bool Equals(object obj) => default;
		protected bool Equals(SkillType other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
	}
}
