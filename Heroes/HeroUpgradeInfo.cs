
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Numerics;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Heroes
{
	[MessagePackObject]
	public class HeroUpgradeInfo
	{
		// Fields
		[Json]
		// [Key]
		public int XpToUpgrade;
		[Json]
		// [Key]
		public Fixed Coef;
	
		// Constructors
		public HeroUpgradeInfo() {}
	}
}
