
using System;
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
	public class UserOfferPrizeInfo
	{
		// Fields
		[Json]
		// [Key]
		public UnitedPrize Prize;
		[Json]
		// [Key]
		public DateTime? TakenTime;
	
		// Constructors
		public UserOfferPrizeInfo() {}
		public UserOfferPrizeInfo(UnitedPrize prize) {}
	}
}
