
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
	public class TaxData
	{
		// Fields
		[Json]
		// [Key]
		public double? LocalTaxPercent;
		[Json]
		// [Key]
		public double? LocalTaxAmount;
		[Json]
		// [Key]
		public double? StateTaxPercent;
		[Json]
		// [Key]
		public double? StateTaxAmount;
	
		// Constructors
		public TaxData() {}
	}
}
