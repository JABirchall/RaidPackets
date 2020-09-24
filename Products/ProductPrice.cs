
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Products
{
	[MessagePackObject]
	public class ProductPrice
	{
		// Fields
		[Json]
		// [Key]
		public string NativeCurrencyCode;
		[Json]
		// [Key]
		public string ActualCurrencyCode;
		[Json]
		// [Key]
		public string PriceFormat;
	
		// Constructors
		public ProductPrice() {}
	}
}
