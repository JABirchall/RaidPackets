
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.LoyaltyProgram.Data
{
	[MessagePackObject]
	public class LoyaltyProgramState
	{
		// Fields
		[Json]
		// [Key]
		public DateTime? StartDate;
		[Json]
		// [Key]
		public List<DateTime> PrizeReceivedDates;
	
		// Constructors
		public LoyaltyProgramState() {}
	}
}
