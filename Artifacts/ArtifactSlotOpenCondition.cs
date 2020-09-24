
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Heroes;



namespace SharedModel.Meta.Artifacts
{
	[MessagePackObject]
	public class ArtifactSlotOpenCondition
	{
		// Fields
		[Json]
		// [Key]
		public HeroGrade? HeroGrade;
		[Json]
		// [Key]
		public int? AwakeLevel;
	
		// Constructors
		public ArtifactSlotOpenCondition() {}
	
		// Methods
		public bool Satisfies(Hero hero) => default;
	}
}
