
using System;
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
	public class ReferralReward
	{
		// Fields
		[Json]
		// [Key]
		public int Level;
		[Json]
		// [Key]
		public UserPrize Prize;
	
		// Constructors
		public ReferralReward() {}
		public ReferralReward(int level, UserPrize prize) {}
	}
}
