
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
	public class ShortHeroInfo
	{
		// Fields
		[Json]
		// [Key]
		public int HeroTypeId;
		[Json]
		// [Key]
		public HeroGrade Grade;
		[Json]
		// [Key]
		public int Level;
	
		// Constructors
		public ShortHeroInfo() {}
		public ShortHeroInfo(int heroTypeId, HeroGrade grade, int level) {}
	}
}
