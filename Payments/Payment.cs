
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Payments.Data;



namespace SharedModel.Meta.Payments
{
	[MessagePackObject]
	public class Payment
	{
		// Fields
		[Json]
		// [Key]
		public int Id;
		[Json]
		// [Key]
		public string BillingTxId;
		[Json]
		// [Key]
		public string ClientTxId;
		[Json]
		// [Key]
		public BillingPrice Price;
		[Json]
		// [Key]
		public string OriginalCurrency;
		[Json]
		// [Key]
		public double? OriginalAmount;
		[Json]
		// [Key]
		public bool ClosedManually;
		[Json]
		// [Key]
		public OfferPaymentInfo OfferInfo;
		[Json]
		// [Key]
		public SubscriptionPaymentInfo SubscriptionInfo;
		[Json]
		// [Key]
		public BattlePassPaymentInfo BattlePassInfo;
		[Json]
		// [Key]
		public GooglePointsPaymentInfo GooglePointsInfo;
		[Json]
		// [Key]
		public DateTime Time;
		[Json]
		// [Key]
		public DateTime? RefundDate;
		[Json]
		// [Key]
		public int? PaymentMethodId;
		[Json]
		// [Key]
		public int? PaymentProviderId;
		[Json]
		// [Key]
		public int? NetEasePaymentTypeId;
		[Json]
		// [Key]
		public TaxData Taxes;
	
		// Constructors
		public Payment() {}
	}
}
