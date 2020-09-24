
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
	public class SeenTodayOfferIdDto
	{
		// Fields
		[Json]
		// [Key]
		public int? OpenOfferId;
		[Json]
		// [Key]
		public int? GiveOfferId;
		[Json]
		// [Key]
		public DoubleGiveOfferId DoubleOfferId;
	
		// Constructors
		public SeenTodayOfferIdDto() {}
	}
}
