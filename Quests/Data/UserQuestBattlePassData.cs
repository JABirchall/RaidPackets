
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
	public class UserQuestBattlePassData
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<int, List<int>> CompletedPrototypeIdsByBattlePassId;
	
		// Constructors
		public UserQuestBattlePassData() {}
	}
}
