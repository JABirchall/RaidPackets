
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.GlobalEvents.Entities
{
	[MessagePackObject]
	public class GlobalEventReward
	{
		// Fields
		[Json]
		// [Key]
		public List<GlobalEventRewardItem> ShopItems;
		[Json]
		// [Key]
		public List<GlobalEventRewardItem> ProgressionReward;
		[Json]
		// [Key]
		public List<UserPrize> PositionRewards;
		[Json]
		// [Key]
		public UserPrize EverydayReward;
	
		// Constructors
		public GlobalEventReward() {}
	
		// Methods
		public GlobalEventReward Clone() => default;
	}
}
