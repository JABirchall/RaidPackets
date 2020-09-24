
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
	public class ReferralProgramSlot
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public long? ReferralUserId;
		[Json]
		// [Key]
		public List<int> LevelsOfClaimedRewards;
	
		// Constructors
		public ReferralProgramSlot() {}
		public ReferralProgramSlot(int id) {}
	}
}
