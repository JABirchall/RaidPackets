
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Battle.Arena3x3
{
	[MessagePackObject]
	public class UserArena3x3ShopItemData
	{
		// Fields
		[Json]
		// [Key]
		public int ItemId;
		[Json]
		// [Key]
		public int PurchasesCount;
		[Json]
		// [Key]
		public DateTime LastPurchaseTime;
	
		// Constructors
		public UserArena3x3ShopItemData() {}
	}
}
