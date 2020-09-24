
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



namespace SharedModel.Meta.Offers.Dto
{
	[MessagePackObject]
	public class DynamicPriceOfferDto
	{
		// Fields
		[Json]
		// [Key]
		public Dictionary<int, Account.Resources> PricesScale;
		[Json]
		// [Key]
		public CooldownPurchaseType CooldownPurchaseLimit;
	
		// Constructors
		public DynamicPriceOfferDto() {}
	
		// Methods
		public DynamicPriceOfferDto Clone() => default;
	}
}
