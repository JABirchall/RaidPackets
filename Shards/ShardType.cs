
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Attributes;
using SharedModel.Common.Localization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Shards
{
	[MessagePackObject]
	// [RemovedJson]
	public class ShardType
	{
		// Fields
		[Json]
		// [Key]
		public ShardTypeId Id;
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
		public Account.Resources Price;
		[Json]
		// [Key]
		public Account.Resources ActivationPrice;
		[Json]
		// [Key]
		public List<Element> ApplicableElements;
		[Json]
		// [Key]
		public List<ShardDropRule> DropRules;
		[Json]
		// [Key]
		public Dictionary<HeroRarity, Dictionary<int, double>> HeroChancesByIdByRarity;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<HeroRarity, double> _baseHeroRarities;
		[IgnoreMember]
		[JsonSkip]
		private Dictionary<HeroRarity, ShardDropRule> _dropRulesByRarities;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public bool IsAncient { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool IsVoid { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public bool IsLegendary { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<HeroRarity, double> BaseHeroRarities { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<HeroRarity, ShardDropRule> DropRulesByRarities { get => default; }
	
		// Constructors
		public ShardType() {}
	}
}
