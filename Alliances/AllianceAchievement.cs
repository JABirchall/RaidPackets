
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
	public class AllianceAchievement
	{
		// Fields
		[Json]
		// [Key]
		public AllianceAchievementTypeId TypeId;
		[Json]
		// [Key]
		public long Value;
		[Json]
		// [Key]
		public int Level;
	
		// Constructors
		public AllianceAchievement() {}
		public AllianceAchievement(AllianceAchievementTypeId typeId, long value) {}
	}
}
