
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
	public class PaymentData
	{
		// Fields
		[Json]
		// [Key]
		public int? PriceId;
		[Json]
		// [Key]
		public double Amount;
		[Json]
		// [Key]
		public string AmountCurrency;
		[Json]
		// [Key]
		public int? Method;
		[Json]
		// [Key]
		public int? Provider;
		[Json]
		// [Key]
		public TaxData Taxes;
	
		// Constructors
		public PaymentData() {}
	}
}
