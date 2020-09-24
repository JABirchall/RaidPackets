
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Core.Skill.EffectContexts;
using SharedModel.Battle.Effects;
using SharedModel.Common.ExpressionParser;
using SharedModel.Meta.Account;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Skills
{
	[MessagePackObject]
	public class StaticSkillData
	{
		// Fields
		[Json]
		// [Key]
		public List<SkillType> SkillTypes;
		[Json]
		// [Key]
		public Dictionary<HeroRarity, Account.Resources> LevelUpPriceByRarity;
		[Json]
		// [Key]
		public int LevelUpMaterialsLimit;
		[Json]
		// [Key]
		public List<int> CheatSkillIds;
		[JsonSkip]
		private Dictionary<int, SkillType> _skillTypeById;
		[JsonSkip]
		private Dictionary<int, EffectKindId> _effectKindByEffectId;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<int, SkillType> SkillTypeById { get => default; }
	
		// Constructors
		public StaticSkillData() {}
	
		// Methods
		public void Cache(ExpressionBuilder<EffectContext> parser) {}
		public static void CacheEffectsFunctions(IEnumerable<EffectType> effectTypes, ExpressionBuilder<EffectContext> parser) {}
		public SkillType GetSkillType(int typeId, bool throwException = true) => default;
		public EffectKindId? GetEffectKindId(int effectId) => default;
	}
}
