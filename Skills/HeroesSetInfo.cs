
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;



namespace SharedModel.Meta.Skills
{
	[MessagePackObject]
	public class HeroesSetInfo : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public int[] TypeIds;
		[Json]
		// [Key]
		public bool IgnoreDeath;
	
		// Constructors
		public HeroesSetInfo() {}
	
		// Methods
		public override bool Equals(object obj) => default;
		protected bool Equals(HeroesSetInfo other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
	}
}
