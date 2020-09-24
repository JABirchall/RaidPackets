
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Localization;



namespace SharedModel.Meta.Alliances
{
	[MessagePackObject]
	public class AllianceAchievementType
	{
		// Fields
		[Json]
		// [Key]
		public AllianceAchievementTypeId TypeId;
		[Json]
		// [Key]
		// [SharedLocalization]
		public SharedLTextKey Name;
		[Json]
		// [Key]
		// [SharedLocalization]
		public SharedLTextKey Description;
		[Json]
		// [Key]
		public List<AllianceAchievementLevelInfo> LevelInfos;
	
		// Constructors
		public AllianceAchievementType() {}
	
		// Methods
		public AllianceAchievementLevelInfo GetLevelInfo(int level) => default;
	}
}
