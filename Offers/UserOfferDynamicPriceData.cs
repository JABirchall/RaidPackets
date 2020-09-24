
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Account;
using SharedModel.Meta.Offers.Enums;



namespace SharedModel.Meta.Offers
{
	[MessagePackObject]
	public class UserOfferDynamicPriceData
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<int, Account.Resources> PricesScale;
		[Json]
		// [Key]
		public CooldownPurchaseType CooldownPurchaseLimit;
		[Json]
		// [Key]
		public int PurchasesCountBeforeCooldown;
		[Json]
		// [Key]
		public DateTime LastRefreshDate;
	
		// Constructors
		public UserOfferDynamicPriceData() {}
	}
}
