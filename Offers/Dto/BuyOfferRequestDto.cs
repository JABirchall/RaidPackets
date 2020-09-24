
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
	public class BuyOfferRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int PromoOfferId;
		[Json]
		// [Key]
		public bool Activate;
		[Json]
		// [Key]
		public string Name;
		[Json]
		// [Key]
		public bool? IsAutoBattle;
	
		// Constructors
		public BuyOfferRequestDto() {}
	}
}
