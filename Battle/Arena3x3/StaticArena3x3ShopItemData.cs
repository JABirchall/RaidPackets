
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Battle.Arena;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.Battle.Arena3x3
{
	[MessagePackObject]
	public class StaticArena3x3ShopItemData
	{
		// Fields
		[Json]
		// [Key]
		public int OrderById;
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public ArenaLeagueId ArenaLeagueId;
		[Json]
		// [Key]
		public UserPrize Prize;
		[Json]
		// [Key]
		public Account.Resources Price;
		[Json]
		// [Key]
		public int PurchaseCooldownInSec;
		[Json]
		// [Key]
		public int? MonthNumber;
	
		// Constructors
		public StaticArena3x3ShopItemData() {}
	}
}
