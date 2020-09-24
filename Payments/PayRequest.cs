
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Plarium.Common.Serialization;
using SharedModel.Meta.Payments.Data;
using SharedModel.Meta.Subscriptions.Data;



namespace SharedModel.Meta.Payments
{
	public class PayRequest
	{
		// Fields
		[Json]
		public long UserId;
		[Json]
		public string BillingTxId;
		[Json]
		public BillingOperationType BillingOperationType;
		[Json]
		public string ClientTxId;
		[Json]
		public CheckCustomData CustomData;
		[Json]
		public SubscriptionPayData SubscriptionData;
		[Json]
		public GooglePointsData GooglePointsData;
		[Json]
		public int PriceId;
		[Json]
		public TaxData Taxes;
		[Json]
		public int? PaymentMethodId;
		[Json]
		public int? PaymentProviderId;
		[Json]
		public int? NetEasePaymentTypeId;
		[Json]
		public string OriginalCurrency;
		[Json]
		public double? OriginalAmount;
		[Json]
		public double Amount;
		[Json]
		public string Currency;
		[Json]
		public bool IsTestPayment;
	
		// Constructors
		public PayRequest() {}
	
		// Methods
		public static PayRequest Build(long userId, PayRequestDto dto) => default;
	}
}
