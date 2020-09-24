
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.GiftLinkRewards
{
	[MessagePackObject]
	public class GiftLinkRewardsData
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<string, UserPrize> RewardsByPackageId;
		[Json]
		// [Key]
		public int Revision;
	
		// Constructors
		public GiftLinkRewardsData() {}
	}
}
