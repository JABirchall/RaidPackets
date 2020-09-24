
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.ReferralProgram.Data
{
	[MessagePackObject]
	public class UserReferralProgramData
	{
		// Fields
		public const int SlotsCount = 3;
		[Json]
		// [Key]
		public List<ReferralProgramSlot> Slots;
		[Json]
		// [Key]
		public long? ReferrerId;
		[Json]
		// [Key]
		public bool? ClaimedReferralReward;
		[Json]
		// [Key]
		public bool? ClaimedFullSlotsReward;
		[Json]
		// [Key]
		public string ReferrerLink;
	
		// Constructors
		public UserReferralProgramData() {}
	
		// Methods
		public static UserReferralProgramData New() => default;
	}
}
