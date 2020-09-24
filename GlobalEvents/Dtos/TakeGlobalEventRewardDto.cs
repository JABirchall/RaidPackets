
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.GlobalEvents.Dtos
{
	[MessagePackObject]
	public class TakeGlobalEventRewardDto
	{
		// Fields
		[Json]
		// [Key]
		public int RewardId;
		[Json]
		// [Key]
		public int PrototypeId;
	
		// Constructors
		public TakeGlobalEventRewardDto() {}
	}
}
