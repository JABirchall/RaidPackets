
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
	public class StaticLoyaltyProgramData
	{
		// Fields
		[Json]
		// [Key]
		public LoyaltyProgramSettings Settings;
		[Json]
		// [Key]
		public Dictionary<LoyaltyProgramTypeId, List<LoyaltyProgramDay>> LoyaltyProgramDaysByProgramTypeId;
	
		// Constructors
		public StaticLoyaltyProgramData() {}
	}
}
