
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Numerics;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;



namespace SharedModel.Meta.Skills
{
	[MessagePackObject]
	public class SkillBonus : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public SkillBonusType SkillBonusType;
		[Json]
		// [Key]
		public Fixed Value;
	
		// Constructors
		public SkillBonus() {}
	
		// Methods
		public void Validate(string error) {}
		public override bool Equals(object obj) => default;
		protected bool Equals(SkillBonus other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
	}
}
