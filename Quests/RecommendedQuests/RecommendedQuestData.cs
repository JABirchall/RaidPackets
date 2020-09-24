
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Quests.RecommendedQuests
{
	[MessagePackObject]
	public class RecommendedQuestData
	{
		// Fields
		[Json]
		// [Key]
		public List<RecommendedQuestGroupInfo> GroupInfos;
	
		// Constructors
		public RecommendedQuestData() {}
	}
}
