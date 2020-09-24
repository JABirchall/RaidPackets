
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Inbox;
using SharedModel.Meta.Offers;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Offers.Dto
{
	[MessagePackObject]
	public class BuyOfferResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public Resources Price;
		[Json]
		// [Key]
		public List<InboxItem> InboxItems;
		[Json]
		// [Key]
		public UserOffer UserOffer;
		[Json]
		// [Key]
		public UserPrize UserPrize;
	
		// Constructors
		public BuyOfferResponseDto() {}
		public BuyOfferResponseDto(Resources price, List<InboxItem> inboxItems, UserOffer userOffer, UserPrize userPrize) {}
	}
}
