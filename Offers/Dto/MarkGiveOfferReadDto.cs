
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Attributes;
using SharedModel.Meta.Offers.Enums;



namespace SharedModel.Meta.Offers.Dto
{
	[MessagePackObject]
	// [RemovedJson]
	public class MarkGiveOfferReadDto
	{
		// Fields
		[Json]
		// [Key]
		public int[] Ids;
		[Json]
		// [Key]
		public ExposureLocation ExposureLocation;
	
		// Constructors
		public MarkGiveOfferReadDto() {}
	}
}
