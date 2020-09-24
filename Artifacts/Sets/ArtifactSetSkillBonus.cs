
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Hashing;



namespace SharedModel.Meta.Artifacts.Sets
{
	[MessagePackObject]
	public class ArtifactSetSkillBonus : IHashable
	{
		// Fields
		[Json]
		// [Key]
		public int SkillTypeId;
	
		// Constructors
		public ArtifactSetSkillBonus() {}
		public ArtifactSetSkillBonus(int skillTypeId) {}
	
		// Methods
		public ArtifactSetSkillBonus Clone() => default;
		public override bool Equals(object obj) => default;
		protected bool Equals(ArtifactSetSkillBonus other) => default;
		public override int GetHashCode() => default;
		public int CalcHash() => default;
	}
}
