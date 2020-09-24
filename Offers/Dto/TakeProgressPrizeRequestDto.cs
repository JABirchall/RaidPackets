
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Offers.Dto
{
	[MessagePackObject]
	public class TakeProgressPrizeRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int PromoOfferId;
		[Json]
		// [Key]
		public int Level;
	
		// Constructors
		public TakeProgressPrizeRequestDto() {}
	}
}
