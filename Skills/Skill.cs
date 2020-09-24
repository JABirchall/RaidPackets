
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Skills
{
	[MessagePackObject]
	public class Skill
	{
		// Fields
		[IgnoreMember]
		[JsonSkip]
		private SkillType _type;
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public int TypeId;
		[Json]
		// [Key]
		public int Level;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public SkillType Type { get => default; }
	
		// Constructors
		public Skill() {}
		public Skill(int id, int typeId, int level) {}
	
		// Methods
		public Skill Clone() => default;
	}
}
