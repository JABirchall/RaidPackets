
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Offers.Enums;



namespace SharedModel.Meta.Offers.Dto
{
	[MessagePackObject]
	public class InterfaceSettingsDto
	{
		// Fields
		[Json]
		// [Key]
		public BankTab Tab;
		[Json]
		// [Key]
		public int Position;
		[Json]
		// [Key]
		public int Discount;
		[Json]
		// [Key]
		public string ImageBundle;
		[Json]
		// [Key]
		public string IconBundle;
		[Json]
		// [Key]
		public int TitleId;
		[Json]
		// [Key]
		public int? TabNameId;
		[Json]
		// [Key]
		public int? DescriptionId;
		[Json]
		// [Key]
		public int? CtaId;
		[Json]
		// [Key]
		public OfferIndicator? Indicator;
		[Json]
		// [Key]
		public Dictionary<int, string> ProgressPackageIconPerLevel;
		[Json]
		// [Key]
		public UserPrizeOrder Order;
		[Json]
		// [Key]
		public ProgressUserPrizeOrderDto ProgressOfferOrderDto;
		[Json]
		// [Key]
		public RetentionUserPrizeOrderDto RetentionOfferOrderDto;
	
		// Constructors
		public InterfaceSettingsDto() {}
	}
}
