
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Quests;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Quests.RecommendedQuests
{
	[MessagePackObject]
	public class RecommendedQuestGroupInfo
	{
		// Fields
		[Json]
		// [Key]
		public RecommendedQuestGroupId GroupId;
		[Json]
		// [Key]
		public UserPrize Reward;
	
		// Constructors
		public RecommendedQuestGroupInfo() {}
	}
}
