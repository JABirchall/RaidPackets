
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Alliances
{
	[MessagePackObject]
	public class AllianceAchievementLevelInfo
	{
		// Fields
		[Json]
		// [Key]
		public long Value;
		[Json]
		// [Key]
		public int? Required;
		[Json]
		// [Key]
		public long RatingBonus;
	
		// Constructors
		public AllianceAchievementLevelInfo() {}
	}
}
