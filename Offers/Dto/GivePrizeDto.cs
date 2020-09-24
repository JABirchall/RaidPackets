
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Offers.Dto
{
	[MessagePackObject]
	public class GivePrizeDto
	{
		// Fields
		[Json]
		// [Key]
		public long UserId;
		[Json]
		// [Key]
		public PrizeSource Source;
		[Json]
		// [Key]
		public int? PriceId;
		[Json]
		// [Key]
		public UserPrize Prize;
	
		// Constructors
		public GivePrizeDto() {}
	}
}
