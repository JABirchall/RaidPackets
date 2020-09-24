
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Quests.Data
{
	[MessagePackObject]
	public class UserQuestDataAchievements
	{
		// Fields
		[Json]
		// [Key]
		public List<int> CompletedQuestIds;
	
		// Constructors
		public UserQuestDataAchievements() {}
	
		// Methods
		public static int ToShortPrototypeId(int fullPrototypeId) => default;
		public static int ToFullPrototypeId(int shortPrototypeId) => default;
	}
}
