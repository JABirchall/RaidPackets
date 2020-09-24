
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Common.Attributes;



namespace SharedModel.Meta.Offers
{
	[MessagePackObject]
	// [RemovedJson]
	public class UserOfferData
	{
		// Fields
		[Json]
		// [Key]
		public int LastOfferId;
		[Json]
		// [Key]
		public List<UserOffer> OpenOffers;
		[Json]
		// [Key]
		public List<UserOffer> GiveOffers;
		[Json]
		// [Key]
		public List<int> SeenOpenOfferIdsToday;
		[Json]
		// [Key]
		public List<int> SeenGiveOfferIdsToday;
	
		// Constructors
		public UserOfferData() {}
	}
}
