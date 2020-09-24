
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
	public class InfluencerRewardType
	{
		// Fields
		[Json]
		// [Key]
		public InfluencerRewardId Id;
		[Json]
		// [Key]
		public UserPrize Prize;
	
		// Constructors
		public InfluencerRewardType() {}
	}
}
