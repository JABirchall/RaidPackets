
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Inbox;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Battle.Arena3x3
{
	[MessagePackObject]
	public class BuyArena3x3ShopItemResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public UserPrize Prize;
		[Json]
		// [Key]
		public List<InboxItem> InboxItems;
	
		// Constructors
		public BuyArena3x3ShopItemResponseDto() {}
		public BuyArena3x3ShopItemResponseDto(UserPrize prize, List<InboxItem> inboxItems) {}
	}
}
