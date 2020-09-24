
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Skills;



namespace SharedModel.Meta.Heroes.Dtos
{
	[MessagePackObject]
	public class LevelUpSkillResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public List<Skill> HeroSkills;
		[Json]
		// [Key]
		public List<int> UpgradedSkillIds;
	
		// Constructors
		public LevelUpSkillResponseDto() {}
	}
}
