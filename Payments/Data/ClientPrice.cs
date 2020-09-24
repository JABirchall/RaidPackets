
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Payments.Data
{
	[MessagePackObject]
	public class ClientPrice
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public string IapProductSku;
		[Json]
		// [Key]
		public double Amount;
		[Json]
		// [Key]
		public string Currency;
		[Json]
		// [Key]
		public bool IsPromoted;
		[IgnoreMember]
		[JsonSkip]
		public string NativePrice;
		[IgnoreMember]
		[JsonSkip]
		public string PriceCurrencyCode;
	
		// Properties
		[IgnoreMember]
		[JsonSkip]
		public string FormattedPrice { get; set; }
	
		// Constructors
		public ClientPrice() {}
	}
}
