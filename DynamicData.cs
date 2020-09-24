
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.GiftLinkRewards;
using SharedModel.Meta.ReferralProgram;
using SharedModel.Meta.Shards;
using SharedModel.Meta.Stages;



namespace SharedModel.Meta
{
	[MessagePackObject]
	public class DynamicData
	{
		// Fields
		[Json]
		// [Key]
		public DynamicStageData StageData;
		[Json]
		// [Key]
		public DynamicShardData ShardData;
		[Json]
		// [Key]
		public GiftLinkRewardsData GiftLinkRewardsData;
		[Json]
		// [Key]
		public InfluencerLinkRewardsData InfluencerLinkRewardsData;
	
		// Constructors
		public DynamicData() {}
	}
}
