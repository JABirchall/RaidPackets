
using System;
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
	public class GlobalEventRewardItem
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public int Points;
		[Json]
		// [Key]
		public int? Limit;
		[Json]
		// [Key]
		public UserPrize Prize;
		[Json]
		// [Key]
		public bool Taken;
	
		// Constructors
		public GlobalEventRewardItem() {}
	
		// Methods
		public GlobalEventRewardItem Clone() => default;
	}
}
