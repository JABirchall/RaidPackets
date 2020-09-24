
using System;
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
	public class GlobalEventConditionRule
	{
		// Fields
		[Json]
		// [Key]
		public HeroRarity? Rarity;
		[Json]
		// [Key]
		public HeroFraction? Fraction;
		[Json]
		// [Key]
		public HeroRace? Race;
		[Json]
		// [Key]
		public bool OneOfAnyFractionOnly;
	
		// Constructors
		public GlobalEventConditionRule() {}
	}
}
