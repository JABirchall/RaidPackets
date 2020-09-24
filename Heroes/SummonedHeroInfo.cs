
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Heroes
{
	[MessagePackObject]
	public class SummonedHeroInfo
	{
		// Fields
		[Json]
		// [Key]
		public int SummonedHeroId;
		[Json]
		// [Key]
		public int HeroTypeId;
		[Json]
		// [Key]
		public HeroGrade Grade;
	
		// Constructors
		public SummonedHeroInfo() {}
		public SummonedHeroInfo(int summonedHeroId, int heroTypeId, HeroGrade grade) {}
	}
}
