
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.ReferralProgram
{
	[MessagePackObject]
	public class InfluencerLinkRewardsData
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<string, UserPrize> RewardsByPackageId;
		[Json]
		// [Key]
		public int Revision;
	
		// Constructors
		public InfluencerLinkRewardsData() {}
	}
}
