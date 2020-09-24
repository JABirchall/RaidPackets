
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Fuse.Static
{
	[MessagePackObject]
	public class FuseHeroMaterial
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
		public FuseHeroMaterial() {}
		public FuseHeroMaterial(int heroTypeId, HeroGrade grade, int level) {}
	}
}
