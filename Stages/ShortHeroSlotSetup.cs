
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Battle.Core.Setup;
using SharedModel.Common.Hashing;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Stages
{
	[MessagePackObject]
	public class ShortHeroSlotSetup : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public int Round;
		[Json]
		// [Key]
		public int Slot;
		[Json]
		// [Key]
		public int HeroTypeId;
		[Json]
		// [Key]
		public HeroGrade Grade;
		[Json]
		// [Key]
		public int Level;
		[Json]
		// [Key]
		public bool MaxSkillsLevel;
	
		// Constructors
		public ShortHeroSlotSetup() {}
		public ShortHeroSlotSetup(int round, int slot, int heroTypeId, HeroGrade grade, int level) {}
		public ShortHeroSlotSetup(HeroSlotSetup setup) {}
	
		// Methods
		public HeroSlotSetup ToHeroSlotSetup() => default;
		public override bool Equals(object obj) => default;
		protected bool Equals(ShortHeroSlotSetup other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
	}
}
