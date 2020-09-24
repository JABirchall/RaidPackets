
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.ReferralProgram.Data
{
	[MessagePackObject]
	public class StaticReferralProgramData
	{
		// Fields
		[Json]
		// [Key]
		public List<ReferralReward> ProgressRewards;
		[Json]
		// [Key]
		public UserPrize AllSlotsFullReward;
		[Json]
		// [Key]
		public UserPrize ReferralNoviceReward;
		[Json]
		// [Key]
		public ReferralProgramSettings Settings;
		[Json]
		// [Key]
		public List<InfluencerRewardType> InfluencerRewardTypes;
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<int, UserPrize> RewardsByReferralLevel;
		[IgnoreMember]
		[JsonSkip]
		public Dictionary<InfluencerRewardId, UserPrize> InfluencerRewardsByTypeId;
		[IgnoreMember]
		[JsonSkip]
		public int[] MilestoneLevels;
	
		// Constructors
		public StaticReferralProgramData() {}
	
		// Methods
		public void Cache() {}
	}
}
