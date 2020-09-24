
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
	public class BillingPriceAmount
	{
		// Fields
		[Json]
		// [Key]
		public double Amount;
		[Json]
		// [Key]
		public string Currency;
	
		// Constructors
		public BillingPriceAmount() {}
		public BillingPriceAmount(double amount, string currency) {}
	
		// Methods
		public static BillingPriceAmount OfUsd() => default;
	}
}
