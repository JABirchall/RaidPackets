
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharedModel.Common.UserEdit;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.MagicShop
{
	public static class MagicShopExtensions
	{
		// Extension methods
		public static IUndoState AddSlot(this UserMagicShopData data) => default;
		public static UserMagicShopData RemoveSlot(this UserMagicShopData data) => default;
		public static UserMagicShopData AddItem(this UserMagicShopData data, MagicShopItem item) => default;
		public static IUndoState RemoveItem(this UserMagicShopData data, MagicShopItem item, DateTime now) => default;
		public static MagicShopItem SelectItem(this UserMagicShopData data, int id) => default;
		public static Account.Resources GetSlotPrice(this UserMagicShopData data, int slotNumber) => default;
		public static UserMagicShopData AssertNotMaxSlots(this UserMagicShopData data) => default;
		public static bool AncientShardPurchaseLimitReached(this UserMagicShopData data, DateTime now) => default;
		private static IUndoState UpdateAncientShardPurchaseIfNeeded(this UserMagicShopData data, MagicShopItem item, DateTime now) => default;
	}
}
