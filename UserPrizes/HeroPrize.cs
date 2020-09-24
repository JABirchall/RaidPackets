
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Attributes;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.UserPrizes
{
	[MessagePackObject]
	// [RemovedJson]
	public class HeroPrize
	{
		// Fields
		[Json]
		// [Key]
		public int HeroTypeId;
		[Json]
		// [Key]
		public int Count;
		[Json]
		// [Key]
		public int? Level;
		[Json]
		// [Key]
		public bool? Locked;
		[IgnoreMember]
		[JsonSkip]
		private HeroType _type;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public HeroType Type { get => default; }
		[IgnoreMember]
		[JsonSkip]
		public HeroGrade HeroGrade { get => default; }
	
		// Constructors
		public HeroPrize() {}
		public HeroPrize(int heroTypeId, int count = 1, bool? locked = default, int? level = default) {}
	
		// Methods
		public bool Equals(HeroPrize other) => default;
		public override bool Equals(object obj) => default;
		public override int GetHashCode() => default;
		public HeroPrize Clone() => default;
		private static HeroType HeroTypeWith(int heroTypeId) => default;
	}
}
