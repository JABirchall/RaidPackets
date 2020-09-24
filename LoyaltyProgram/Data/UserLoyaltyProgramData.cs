
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
	public class UserLoyaltyProgramData
	{
		// Fields
		[Json]
		// [Key]
		public LoyaltyProgramTypeId CurrentProgramTypeId;
		[Json]
		// [Key]
		public Dictionary<LoyaltyProgramTypeId, LoyaltyProgramState> ProgramStateByTypeId;
	
		// Constructors
		public UserLoyaltyProgramData() {}
	}
}
