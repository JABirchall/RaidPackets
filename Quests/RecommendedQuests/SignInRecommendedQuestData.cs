
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Quests;



namespace SharedModel.Meta.Quests.RecommendedQuests
{
	[MessagePackObject]
	public class SignInRecommendedQuestData
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<RecommendedQuestGroupId, int> QuestsCountByGroupId;
	
		// Constructors
		public SignInRecommendedQuestData() {}
	}
}
