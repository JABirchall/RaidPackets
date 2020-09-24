
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.GlobalEvents.Entities
{
	[MessagePackObject]
	public class GlobalEventHeroRule
	{
		// Fields
		[Json]
		// [Key]
		public HeroGrade? Grade;
		[Json]
		// [Key]
		public HeroRarity? Rarity;
		[Json]
		// [Key]
		public List<Element> Elements;
		[Json]
		// [Key]
		public int? AwakeLevel;
	
		// Constructors
		public GlobalEventHeroRule() {}
	
		// Methods
		public bool Satisfies(HeroGrade grade, HeroRarity rarity, Element element, int awakeLevel) => default;
		public GlobalEventHeroRule Clone() => default;
	}
}
