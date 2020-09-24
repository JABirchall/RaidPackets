
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Payments;



namespace SharedModel.Meta.Offers
{
	[MessagePackObject]
	public class GiveOfferResult
	{
		// Fields
		[Json]
		// [Key]
		public PurchasedOffer PurchasedOffer;
		[Json]
		// [Key]
		public UnitedPrize GivenPrize;
	
		// Constructors
		public GiveOfferResult() {}
	}
}
