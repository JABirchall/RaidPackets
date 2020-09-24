
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.MagicShop
{
	[MessagePackObject]
	public class MagicShopItem
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public MagicShopItemTypeId TypeId;
		[Json]
		// [Key]
		public UserPrize Prize;
		[Json]
		// [Key]
		public Account.Resources Price;
		[Json]
		// [Key]
		public bool IsRare;
	
		// Constructors
		public MagicShopItem() {}
	}
}
