
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
	public class UserQuestDataFeature
	{
		// Fields
		[Json]
		// [Key]
		public List<int> CompletedQuestIds;
	
		// Constructors
		public UserQuestDataFeature() {}
	}
}
