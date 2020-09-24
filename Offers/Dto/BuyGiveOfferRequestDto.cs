
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
	public class BuyGiveOfferRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
	
		// Constructors
		public BuyGiveOfferRequestDto() {}
	}
}
