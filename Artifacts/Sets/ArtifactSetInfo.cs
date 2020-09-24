
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Localization;



namespace SharedModel.Meta.Artifacts.Sets
{
	[MessagePackObject]
	public class ArtifactSetInfo
	{
		// Fields
		[Json]
		// [Key]
		public ArtifactSetKindId ArtifactSetKindId;
		[Json]
		// [Key]
		public int ArtifactCount;
		[Json]
		// [Key]
		public ArtifactSetSkillBonus SkillBonus;
		[Json]
		// [Key]
		public ArtifactSetStatBonus StatBonus;
		[Json]
		// [Key]
		public List<ArtifactSetStatBonus> StatBonuses;
		[Json]
		// [Key]
		// [SharedLocalization]
		public SharedLTextKey Name;
		[Json]
		// [Key]
		// [SharedLocalization]
		public SharedLTextKey ShortDescription;
		[Json]
		// [Key]
		// [SharedLocalization]
		public SharedLTextKey Description;
	
		// Constructors
		public ArtifactSetInfo() {}
	}
}
