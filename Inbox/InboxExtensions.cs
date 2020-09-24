
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Common.UserEdit;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Inbox
{
	public static class InboxExtensions
	{
		// Extension methods
		public static IUndoState AddItem(this UserInboxData data, InboxItem newItem) => default;
		public static IUndoState AddItems(this UserInboxData data, IEnumerable<InboxItem> newItems) => default;
		public static List<int> GetExpiredEffectIds(this UserInboxData data, DateTime time) => default;
		public static InboxItem GetItem(this UserInboxData inboxData, int id) => default;
		public static InboxItem AssertHasItem(this UserInboxData inboxData, int id) => default;
		public static IUndoState RemoveItem(this UserInboxData data, InboxItem item) => default;
		public static InboxItem RemoveItemById(this UserInboxData data, int itemId) => default;
		public static IUndoState RemoveItemIfLimitReached(this UserInboxData inboxData) => default;
		public static UserInboxData RemoveNotValidItems(this UserInboxData inboxData, DateTime time) => default;
		public static bool LimitReached(this UserInboxData inboxData) => default;
		public static UserPrizeSource ToUserPrizeSource(this InboxTypeId typeId) => default;
	}
}
