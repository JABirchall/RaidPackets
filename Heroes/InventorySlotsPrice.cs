
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;



namespace SharedModel.Meta.Heroes
{
	[MessagePackObject]
	public class InventorySlotsPrice
	{
		// Fields
		[Json]
		// [Key]
		public int UserSlotsCount;
		[Json]
		// [Key]
		public Account.Resources SilverPrice;
		[Json]
		// [Key]
		public Account.Resources GemsPrice;
	
		// Constructors
		public InventorySlotsPrice() {}
		public InventorySlotsPrice(int userSlotsCount, Account.Resources silverPrice, Account.Resources gemsPrice) {}
	}
}
