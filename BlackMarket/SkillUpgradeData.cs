
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.BlackMarket
{
	[MessagePackObject]
	public class SkillUpgradeData
	{
		// Fields
		[Json]
		// [Key]
		public List<HeroRarity> AvailableHeroRarities;
	
		// Constructors
		public SkillUpgradeData() {}
	}
}
