
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Configuration;
using Plarium.Common.Serialization;
using SharedModel.Meta.Fuse.Static;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Fuse
{
	[MessagePackObject]
	public class FuseHeroSetting
	{
		// Fields
		[Json]
		// [Key]
		public int OutputHeroId;
		[Json]
		// [Key]
		public HeroGrade OutputHeroGrade;
		[Json]
		// [Key]
		public double PriceInSilver;
		[Json]
		// [Key]
		public List<FuseHeroMaterial> HeroMaterials;
		[Json]
		// [Key]
		public ConfigDateTime AvailableFrom;
		[Json]
		// [Key]
		public ConfigDateTime AvailableTo;
		[Json]
		// [Key]
		public int? UsageLimit;
	
		// Constructors
		public FuseHeroSetting() {}
	}
}
