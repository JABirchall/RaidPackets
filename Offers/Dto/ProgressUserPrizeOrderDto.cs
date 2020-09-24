
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
	public class ProgressUserPrizeOrderDto
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<int, UserPrizeOrder> OrderPerLevel;
	
		// Constructors
		public ProgressUserPrizeOrderDto() {}
	}
}
