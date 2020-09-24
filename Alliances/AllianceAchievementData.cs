
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Alliances
{
	[MessagePackObject]
	public class AllianceAchievementData
	{
		// Fields
		[Json]
		// [Key]
		public List<AllianceAchievement> Achievements;
	
		// Constructors
		public AllianceAchievementData() {}
	}
}
