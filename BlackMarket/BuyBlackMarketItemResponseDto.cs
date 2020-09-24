
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Inbox;



namespace SharedModel.Meta.BlackMarket
{
	[MessagePackObject]
	public class BuyBlackMarketItemResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public Resources Price;
		[Json]
		// [Key]
		public InboxItem InboxItem;
	
		// Constructors
		public BuyBlackMarketItemResponseDto() {}
		public BuyBlackMarketItemResponseDto(Resources price, InboxItem inboxItem) {}
	}
}
