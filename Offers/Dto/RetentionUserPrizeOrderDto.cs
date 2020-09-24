
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Offers.Dto
{
	[MessagePackObject]
	public class RetentionUserPrizeOrderDto
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<int, UserPrizeOrder> OrderPerDay;
		[Json]
		// [Key]
		public UserPrizeOrder EveryDayPrizeOrder;
	
		// Constructors
		public RetentionUserPrizeOrderDto() {}
	}
}
