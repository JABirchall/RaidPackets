
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.FeatureStatuses;
using SharedModel.Meta.Products;



namespace SharedModel.Meta.Payments
{
	[MessagePackObject]
	public class PaymentSettings
	{
		// Fields
		[Json]
		// [Key]
		public double OverdueCoef;
		[Json]
		// [Key]
		public FeatureStatus SubscriptionsStatus;
		[Json]
		// [Key]
		public BillingPaymentSettings Google;
		[Json]
		// [Key]
		public BillingPaymentSettings Apple;
		[Json]
		// [Key]
		public BillingPaymentSettings Editor;
		[Json]
		// [Key]
		public ChinaPaymentSettings China;
		[Json]
		// [Key]
		public ProductSettings ProductSettings;
		[Json]
		// [Key]
		public double PrizeStoringPeriodInDays;
		[Json]
		// [Key]
		public double SubscriptionAdditionalMinutes;
		[Json]
		// [Key]
		public double ReceiptDataUpdatePeriodInHours;
	
		// Constructors
		public PaymentSettings() {}
	}
}
