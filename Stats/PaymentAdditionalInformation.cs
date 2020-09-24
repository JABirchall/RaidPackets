
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Stats
{
	[MessagePackObject]
	public class PaymentAdditionalInformation
	{
		// Fields
		[Json]
		// [Key]
		public string ProviderTransactionStageId;
		[Json]
		// [Key]
		public string ProviderTransactionId;
		[Json]
		// [Key]
		public string PaymentMethod;
		[Json]
		// [Key]
		public string InternalTransactionId;
		[Json]
		// [Key]
		public string Currency;
	
		// Constructors
		public PaymentAdditionalInformation() {}
	}
}
