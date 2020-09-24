
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Offers
{
	[MessagePackObject]
	public class PurchasedOffer
	{
		// Fields
		[Json]
		// [Key]
		public long Id;
		[Json]
		// [Key]
		public long OfferId;
		[Json]
		// [Key]
		public UserPrize PrizeInfo;
	
		// Constructors
		public PurchasedOffer() {}
	}
}
